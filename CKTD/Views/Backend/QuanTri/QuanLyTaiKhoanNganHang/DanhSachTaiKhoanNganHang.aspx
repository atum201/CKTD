<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Backend/QuanTri/QuanTri.master" AutoEventWireup="true" CodeFile="DanhSachTaiKhoanNganHang.aspx.cs" Inherits="Views_Backend_QuanTri_QuanLyTaiKhoanNganHang_DanhSachTaiKhoanNganHang" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTabRow" Runat="Server">
    <ul>
        <li><a href="/Views/Backend/QuanTri/QuanLyDonHang/DanhSachDonHang.aspx">Đơn hàng</a></li>
        <li  class="is-active"><a href="/Views/Backend/QuanTri/QuanLyLoaiTien/DanhSachLoaiTien.aspx">Loại tiền</a></li>
        <li><a href="/Views/Backend/QuanTri/QuanLyNguoiDung/DanhSachNguoiDung.aspx">Người dùng</a></li>        
        <li><a href="/Views/Backend/QuanTri/QuanLyTaiKhoanNganHang/DanhSachTaiKhoanNganHang.aspx">Tài khoản ngân hàng</a></li>
        <li><a href="/Views/Backend/QuanTri/QuanLyTinTuc/DanhSachTinTuc.aspx">Tin tức</a></li>
        <li><a href="/Views/Backend/QuanTri/CauHinhThongTinHeThong.aspx">Hệ thống</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMainColumn" Runat="Server">
    <script>
    function loadDSBanGhi(pageId) {
        $('#dsBanGhi').html("<tr><td colspan='6'><img style='width: 26px; height: 8px;' src='/style/images/loading.gif' ></td></tr>");
        $.ajax({
            url: '/Views/Backend/QuanTri/QuanLyTaiKhoanNganHang/loadDanhSachTaiKhoanNganHang.aspx?pageId=' + pageId + '&pageSize=<%=pageSize %>&totalPage=<%=totalPage %>&totalItem=<%=totalItem %>',
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
	    <h3 class="title"><img src="/Style/images/icon-search.png" /> Tài khoản ngân hàng</h3>
        <a href="/Views/Backend/QuanTri/QuanLyTaiKhoanNganHang/TaoMoiTaiKhoan.aspx">
            Tạo mới 
         </a>


        <div style="overflow-x:auto">
	        <table class="table">
		        <thead>
			        <tr>
				        <th> Số TT</th>
                        <th>Tên chủ thẻ</th>
                        <th>Số tài khoản</th>
                        <th>Hạn mức trong ngày</th>
                        <th>Trạng thái</th>
                        <th></th>
			        </tr>
		        </thead>
		        <tbody id="dsBanGhi">
			
        	<%
                if (listTaiKhoanNganHang != null) {
                    for (int i = 0; i < listTaiKhoanNganHang.Count; i++)
                    { 
                 %>
        	        <tr>
                        <td><%=pageSize*(pageId-1)+(i+1) %></td>
                        <td><%=listTaiKhoanNganHang[i].TenChuThe %></td>
                        <td><%=listTaiKhoanNganHang[i].SoTaiKhoan %></td>
                        <td><%=listTaiKhoanNganHang[i].HanMucTrongNgay.Value.ToString("0.00") %></td>
                        <td><%=listTaiKhoanNganHang[i].TrangThai %></td>

                        
                        <td>
                            <a href="/Views/Backend/QuanTri/QuanLyTaiKhoanNganHang/CapNhatTaiKhoan.aspx?iDTaiKhoanNganHang=<%=listTaiKhoanNganHang[i].ID %>">
                                <span class="icon has-text-success">
                                    <i class="fa fa-edit"></i>
                                </span>
                            </a>
                            <a href="/Views/Backend/QuanTri/QuanLyTaiKhoanNganHang/XoaTaiKhoan.aspx?iDTaiKhoanNganHang=<%=listTaiKhoanNganHang[i].ID %>">
                            <span class="icon has-text-success">
                                 <i class="fa fa-trash" ></i>
                            </span> 
                            </a>
                        </td>
                    </tr>
        	    <%
                    }
                }
                     %>
        	
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

