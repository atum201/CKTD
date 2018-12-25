<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Backend/QuanTri/QuanTri.master" AutoEventWireup="true" CodeFile="DanhSachDonHang.aspx.cs" Inherits="Views_Backend_QuanTri_QuanLyDonHang_DanhSachDonHang" %>
<asp:Content ID="Content2" ContentPlaceHolderID="cphTabRow" Runat="Server">
    <ul>
        <li class="is-active"><a href="/Views/Backend/QuanTri/QuanLyDonHang/DanhSachDonHang.aspx">Đơn hàng</a></li>
        <li><a href="/Views/Backend/QuanTri/QuanLyLoaiTien/DanhSachLoaiTien.aspx">Loại tiền</a></li>
        <li><a href="/Views/Backend/QuanTri/QuanLyNguoiDung/DanhSachNguoiDung.aspx">Người dùng</a></li>        
        <li><a href="/Views/Backend/QuanTri/QuanLyTaiKhoanNganHang/DanhSachTaiKhoanNganHang.aspx">Tài khoản ngân hàng</a></li>
        <li><a href="/Views/Backend/QuanTri/QuanLyTinTuc/DanhSachTinTuc.aspx">Tin tức</a></li>
        <li><a href="/Views/Backend/QuanTri/CauHinhThongTinHeThong.aspx">Hệ thống</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="cphMainColumn" Runat="Server">
    <script>
    function loadDSBanGhi(pageId) {
        $('#dsBanGhi').html("<tr><td colspan='6'><img style='width: 26px; height: 8px;' src='/style/images/loading.gif' ></td></tr>");
        $.ajax({
            url: '/Views/Backend/QuanTri/QuanLyDonHang/loadDanhSachDonHang.aspx?pageId=' + pageId + '&pageSize=<%=pageSize %>&totalPage=<%=totalPage %>&totalItem=<%=totalItem %>',
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
	    <h3 class="title"><img src="/Style/images/icon-search.png" /> Đơn hàng</h3>


        <div style="overflow-x:auto">
	        <table class="table">
		        <thead>
			        <tr>
				        <th> Số TT</th>
                        <th>Ngày tạo</th>
                        <th>Mã giao dịch</th>
                        <th>Loại tiền</th>
                        <th>Số lượng</th>
                        <th>Giá trị</th>
                        <th>Loại đơn hàng</th>
                        <th>Trạng thái</th>
                        <th>Thao tác</th>
			        </tr>
		        </thead>
		        <tbody id="dsBanGhi">
			
        	<%
                if (listDonHang != null) {
                    for (int i = 0; i < listDonHang.Count;i++ )
                    { 
                 %>
        	        <tr>
                        <td><%=pageSize*(pageId-1)+(i+1)  %></td>
                        <td><%=listDonHang[i].NgayTaoDonHang.Value.ToString("dd-MM-yyyy HH:mm:ss") %></td>
                        <td><%=listDonHang[i].MaGiaoDich %></td>
                        <td><%=listDonHang[i].LoaiTien.TenLoaiTien %></td>
                        <td><%=listDonHang[i].SoLuong %></td>
                        <td><%=listDonHang[i].GiaTri.Value.ToString("0.#") %> VND</td>
                        <td><%=(listDonHang[i].LoaiDonHang=="KhachMua")?"đơn mua":"đơn bán" %></td>
                        <td><%=listDonHang[i].TrangThai %></td>
                        <td>
                            <a href="/Views/Backend/QuanTri/QuanLyDonHang/CapNhatDonHang.aspx?maGiaoDich=<%=listDonHang[i].MaGiaoDich %>">
                                <span class="icon has-text-success">
                                    <i class="fa fa-edit"></i>
                                </span>
                            </a>
                            <span class="icon has-text-success">
                                <i class="fa fa-trash"></i>
                            </span>
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

