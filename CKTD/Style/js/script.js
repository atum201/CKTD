var pusher = new Pusher('KF8W34UF9W48JFS985EUJGW8AW4JFS9EJRFAOWIK', {
    'wsHost' : 'slanger.ipserver.ml',
    'wsPort': '8880',
    'wssPort': '2096'
});

var channel = pusher.subscribe('tiktakbtc');
channel.bind('tygia', function(data) {
	$("#r_btc_mua").text($.number(data.BTC.Mua));
	$("#r_btc_ban").text($.number(data.BTC.Ban));
	if (typeof tygia_BTC !== "undefined"){
		tygiaMua = data.BTC.Mua;
		tygiaBan = data.BTC.Ban;
	}

	$("#r_eth_mua").text($.number(data.ETH.Mua));
	$("#r_eth_ban").text($.number(data.ETH.Ban));
	if (typeof tygia_ETH !== "undefined"){
		tygiaMua = data.ETH.Mua;
		tygiaBan = data.ETH.Ban;
	}

	$("#r_ltc_mua").text($.number(data.LTC.Mua));
	$("#r_ltc_ban").text($.number(data.LTC.Ban));
	if (typeof tygia_LTC !== "undefined"){
		tygiaMua = data.LTC.Mua;
		tygiaBan = data.LTC.Ban;
	}

	$("#r_bcc_mua").text($.number(data.BCC.Mua));
	$("#r_bcc_ban").text($.number(data.BCC.Ban));
	if (typeof tygia_BCC !== "undefined"){
		tygiaMua = data.BCC.Mua;
		tygiaBan = data.BCC.Ban;
	}
});

channel.bind('showvi', function(data) {
	var html = "<div class='text-center'>";
	html += "<div class='qrcode_"+data.Ma+"' data-code='"+data.QRCode+"'></div>";
	html += "<p></p>";
	html += "<p>Vui lòng chuyển đúng <b class='textBlue'>"+data.Amount+"</b> "+data.Coin+" vào địa chỉ</p>";
	html += "<p></p>";
	html += "<h4 class='textBlue'>"+data.Vi+"</h4>";
	html += "<button class='button is-success text-copy' data-clipboard-text='"+data.Vi+"'>Copy address</button>";
	html += "<p></p>";
	html += "</div>";

	$("#vi_" + data.Ma).fadeOut().html("");
	$("#vi_" + data.Ma).html(html).fadeIn();

	$('.qrcode_' + data.Ma).qrcode({ 
        render: 'image',
        text: $('.qrcode_' + data.Ma).attr("data-code"),
        size: "203"
    });
});

channel.bind('orderhoanthanh', function(data) {
	$("#vi_" + data.Ma).fadeOut();
	$("#hieuluc_" + data.Ma).fadeOut();

	var html = "<div class='column label'>Trạng thái</div>";
	html += "<div class='column textBlue'>"+data.Trangthai+"</div>";
	$("#trangthai_" + data.Ma).html(html).fadeOut().fadeIn();

	setTimeout(function() {
		$("#vi_" + data.Ma).html("");
		$("#hieuluc_" + data.Ma).remove();
	}, 2000);
});

$(function() {
	var clipboard = new Clipboard('.text-copy');

	clipboard.on('success', function(e) {
	    alert('Đã sao chép: ' + e.text);
	    e.clearSelection();
	});
	
    $('.timeCountDown').each(function(i){
        $(this).countdown($(this).attr("data-time"),function(event) {
            $(this).text(
              event.strftime('%M:%S')
            );
            if (event.elapsed) {
	    		$(".hieuluc").html("<div class='column label'>Hiệu lực lệnh này còn</div><div class='column note'>**Lệnh đã hết hiệu lực**</div>").fadeOut().fadeIn();
	    	}
         });
    })
});

$(document).ready(function(){
	$(function() {
        $('.qrcode').qrcode({ 
            render: 'image',
            text: $('.qrcode').attr("data-code"),
            size: "203"
        });
    });
	
	$(".sotk").focusout(function(){
		$.get("api/check?bank=" + $(this).attr("dt-bank") + "&sotk=" + $(this).val(),function(data){
			$(".tentk").val(data);
		});
	});

	$(".amount_mua").keyup(function(){
        var tong = parseFloat($(this).val()) * parseFloat(tygiaMua);
        if($(this).val() == "") tong = "";
        $(".vnd_mua").val($.number(tong));
    });

    $(".amount_ban").keyup(function(){
        var tong = parseFloat($(this).val()) * parseFloat(tygiaBan) - 3300;
        if($(this).val() == "") tong = "";
        $(".vnd_ban").val($.number(tong));
    });

	$(".subfrm").click(function(){
		var btn = $(this);
		var frm = $(this).parent().parent().parent();
		var inputs = {};

		frm.find(".input").each(function(){
			$(this).removeClass("is-danger");
			if ($(this).attr("name")) {
				inputs[$(this).attr("name")] = $(this).val();
			}
		});

		var url = frm.attr("action");

		$.ajax({
			url: url,
			type: "POST",
			dataType: "JSON",
			data: inputs,
			beforeSend:function(){
				btn.append("<i style='margin-left: 5px' class='fa fa-circle-o-notch fa-spin'></i>");
			},
			success:function(data){
				btn.find("i").remove();

				if (data.status == "true") {
					window.location.href = data.url;
				}
				else{
					frm.find("input[name='"+data.name+"']").addClass("is-danger");
					if(data.mess)
						alert(data.mess);
				}
			}
		});
	});

	if ($('#back-to-top').length) {
        var scrollTrigger = 100, // px
            backToTop = function () {
                var scrollTop = $(window).scrollTop();
                if (scrollTop > scrollTrigger) {
                    $('#back-to-top').addClass('show');
                } else {
                    $('#back-to-top').removeClass('show');
                }
            };
        backToTop();
        $(window).on('scroll', function () {
            backToTop();
        });
        $('#back-to-top').on('click', function (e) {
            e.preventDefault();
            $('html,body').animate({
                scrollTop: 0
            }, 700);
        });
    }
});