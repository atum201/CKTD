<%@ Page Title="" Language="C#" MasterPageFile="~/OneColumn.master" AutoEventWireup="true" CodeFile="DanhSachDonHangNguoiDung.aspx.cs" Inherits="Views_Backend_NguoiDung_DanhSachDonHangNguoiDung" %>

<asp:Content ID="Content1" ContentPlaceHolderID="mainColumn" Runat="Server">
    <div id="scroll_div" class="column is-12 leftSide" >
	    <h3 class="title"><img src="/Style/images/icon-search.png" /> Đơn hàng</h3>


        <div style="overflow-x:auto">
	        <table class="table">
		        <thead>
			        <tr>
				       
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
                       
                        <td><%=listDonHang[i].NgayTaoDonHang.Value.ToString("dd-MM-yyyy HH:mm:ss") %></td>
                        <td><%=listDonHang[i].MaGiaoDich %></td>
                        <td><%=listDonHang[i].LoaiTien.TenLoaiTien %></td>
                        <td><%=listDonHang[i].SoLuong %></td>
                        <td><%=listDonHang[i].GiaTri.Value.ToString("0.#") %> VND</td>
                        <td><%=(listDonHang[i].LoaiDonHang=="KhachMua")?"đơn mua":"đơn bán" %></td>
                        <td><%=listDonHang[i].TrangThai %></td>
                        <td>
                            <a href="/Views/Frontend/ChiTietDonHang.aspx?maGiaoDich=<%=listDonHang[i].MaGiaoDich %>">
                                <span class="icon has-text-success">
                                    <i class="fa fa-edit"></i>
                                </span>
                            </a>
                            <%--<span class="icon has-text-success">
                                <i class="fa fa-trash"></i>
                            </span>--%>
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
</asp:Content>

