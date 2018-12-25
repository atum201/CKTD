var loaiTien1_mua;
var loaiTien1_ban;
var loaiTien2_mua;
var loaiTien2_ban;
var loaiTien3_mua;
var loaiTien3_ban;
var loaiTien4_mua;
var loaiTien4_ban;


function getGiaTuDong() {
    $.ajax({
        url: '/Views/Frontend/ProcessingAjax.aspx?Command=getGiaTuDong',
        type: 'post',
        dataType: 'json',

        success: (function (response) {
            var tagGia = $('#1_mua_isAutoLoad');
            var temp;
            if (tagGia != null) {
                temp = parseFloat((response.Result.btc_ask + response.Result.btc_ask * phuPhiMua1 * 0.01) / tiGiaVNDUSD).toFixed(2);
                tagGia.html(temp);
                loaiTien1_mua = temp;
            }

            tagGia = $('#1_ban_isAutoLoad');
            if (tagGia != null) {
                temp = parseFloat((response.Result.btc_bid - response.Result.btc_bid * phuPhiBan1 * 0.01) / tiGiaVNDUSD).toFixed(2);
                tagGia.html(temp);
                loaiTien1_ban = temp;
            }

            tagGia = $('#2_mua_isAutoLoad');
            if (tagGia != null) {
                temp = parseFloat((response.Result.eth_ask + response.Result.eth_ask * phuPhiMua2 * 0.01) / tiGiaVNDUSD).toFixed(2);
                tagGia.html(temp);
                loaiTien2_mua = temp;
            }

            tagGia = $('#2_ban_isAutoLoad');
            if (tagGia != null) {
                temp = parseFloat((response.Result.eth_bid - response.Result.eth_bid * phuPhiBan2 * 0.01) / tiGiaVNDUSD).toFixed(2);
                tagGia.html(temp);
                loaiTien2_ban = temp;
            }

            tagGia = $('#3_mua_isAutoLoad');
            if (tagGia != null) {
                temp = parseFloat((response.Result.usdt_ask + response.Result.usdt_ask * phuPhiMua3 * 0.01) / tiGiaVNDUSD).toFixed(2);
                tagGia.html(temp);
                loaiTien3_mua = temp;
            }

            tagGia = $('#3_ban_isAutoLoad');
            if (tagGia != null) {
                temp = parseFloat((response.Result.usdt_bid - response.Result.usdt_bid * phuPhiBan3 * 0.01) / tiGiaVNDUSD).toFixed(2);
                tagGia.html(temp);
                loaiTien3_ban = temp;
            }

            tagGia = $('#4_mua_isAutoLoad');
            if (tagGia != null) {
                temp = parseFloat((response.Result.bch_ask + response.Result.bch_ask * phuPhiMua4 * 0.01) / tiGiaVNDUSD).toFixed(2);
                tagGia.html(temp);
                loaiTien4_mua = temp;
            }

            tagGia = $('#4_ban_isAutoLoad');
            if (tagGia != null) {
                temp = parseFloat((response.Result.bch_bid - response.Result.bch_bid * phuPhiBan4 * 0.01) / tiGiaVNDUSD).toFixed(2);
                tagGia.html(temp);
                loaiTien4_ban = temp;
            }




        })
    });
}

$(function () {

    $('.timeCountDown').each(function (i) {
        $(this).countdown($(this).attr("data-time"), function (event) {
            $(this).text(
              event.strftime('%M:%S')
            );
            if (event.elapsed) {


                $(".hieuluc").html("<div class='column label'>Hiệu lực lệnh này còn</div><div class='column note'>**Lệnh đã hết hiệu lực**</div>").fadeOut().fadeIn();
            }
        });
    })
});

function isExistingBTCAddress(address) {
    var result = false;
    $.ajax({
        url: '/Views/Frontend/ProcessingAjax.aspx?Command=isExistingBTCAddress&address=' + address,
        type: 'get',
        dataType: 'json',
        async: false,
        success: (function (response) {
            obj = response.Result;

            if (obj.error == undefined) {
                result = true;
            }
        })
    });
    return result;
}

function isExistingETHAddress(address) {
    var result = false;
    $.ajax({
        url: '/Views/Frontend/ProcessingAjax.aspx?Command=isExistingETHAddress&address=' + address,
        type: 'get',
        dataType: 'json',
        async: false,
        success: (function (response) {
            obj = response.Result;

            if (obj.error == undefined) {
                result = true;
            }
        })
    });
    return result;
}

function getIDTaiKhoanNganHangConHanMuc(valueTransaction) {

    var result = -1;
    $.ajax({
        url: '/Views/Frontend/ProcessingAjax.aspx?Command=getIDTaiKhoanNganHangConHanMuc',
        data: {
            "valueTransaction": "" + valueTransaction
        },
        type: 'post',
        dataType: 'json',
        async: false,
        success: (function (response) {
            result = response.Result;
        })
    });
    return result;
}

function isInt(n) {
    return Number(n) === n && n % 1 === 0;
}

function isFloat(n) {
    if (isInt(n)) {
        return true;
    }
    return Number(n) === n && n % 1 !== 0;
}