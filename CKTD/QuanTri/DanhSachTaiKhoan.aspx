<%@ Page Language="C#" MasterPageFile="~/QuanTri/QuanTri.master" AutoEventWireup="true" CodeFile="DanhSachTaiKhoan.aspx.cs" Inherits="QuanTri_DanhSachTaiKhoan" %>
<asp:Content ID="ContentLeftColumn" ContentPlaceHolderID="cphLeftColumn" Runat="Server">
    <ul  class="tradeType">
        <li><a href="/QuanTri/DanhSachTaiKhoan.aspx">Danh sách tài khoản</a></li>
        <li><a href="/QuanTri/TaiKhoanDonViChuQuan.aspx">Tài khoản đơn vị chủ quản</a></li>
    </ul>
</asp:Content>
<asp:Content ID="ContentRightColumn" ContentPlaceHolderID="cphRightColumn" Runat="Server">
    <script>
    function loadDSBanGhi(pageId) {
        $('#dsBanGhi').html("<tr><td colspan='6'><img style='width: 26px; height: 8px;' src='/style/images/loading.gif' ></td></tr>");
        $.ajax({
            url: '/QuanTri/loadDanhSach.aspx?pageId=' + pageId + '&pageSize=<%=pageSize %>&totalPage=<%=totalPage %>&totalItem=<%=totalItem %>',
            type: 'post',
            dataType: 'html',
            data: {
            },
            success: (function (html) {
                var nHtml = html.substring(html.indexOf("<div id=\"content\">") + 20);
                $('#dsBanGhi').html(nHtml.substring(0, nHtml.indexOf("</div><!--@@@@@-->")));
                $('#phanTrangBanGhi').html(html.substring(html.indexOf("<!--@@@@@Navigation-->")));

            })
        });
    }
    </script>
    <div id="scroll_div" class="column is-12 leftSide" >
	    <h3 class="title"><img src="/Style/images/icon-search.png" /> Danh sách Tài khoản<%=cktd.countCKTD_DichVuCong(string.Empty) %></h3>
        <a href="/QuanTri/CapNhatTaiKhoan.aspx">
            Tạo mới 
         </a>

        <div style="overflow-x:auto">
	        <table class="table">
		        <thead>
			        <tr>
				        <th>STT</th>
                        <th>Tên hiển thị</th>
                        <th>Tài khoản</th>
                        <th>Loại tài khoản</th>
                        <th>Trạng thái</th>
                        <th>Thời gian cập nhật</th>
                        <th>Thao tác</th>
			        </tr>
		        </thead>
		        <tbody id="dsBanGhi">
        	        <asp:Literal ID="showDanhSach" runat="server"></asp:Literal>
		        </tbody>
	        </table>
        </div>
	
    </div>
    <div id="phanTrangBanGhi">
        <div class="has-text-centered">
            Hiển thị <%=(totalItem==0?0:((pageId*pageSize)-pageSize+1)) %> đến <%=(pageId*pageSize)>totalItem?totalItem:(pageId*pageSize) %> của <%=totalItem %> bản ghi
        </div>
        <nav class="pagination is-centered" role="navigation" aria-label="pagination">
      
          <ul class="pagination-list">
            <asp:Literal ID="ltPage" runat="server"></asp:Literal>
          </ul>
        </nav>
    </div>
    
</asp:Content>
