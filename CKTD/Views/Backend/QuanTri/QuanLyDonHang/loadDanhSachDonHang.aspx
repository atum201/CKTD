<%@ Page Language="C#" AutoEventWireup="true" CodeFile="loadDanhSachDonHang.aspx.cs" Inherits="Views_Backend_QuanTri_QuanLyDonHang_loadDanhSachDonHang" %>

<div id="content">
                
           <%
                if (listDonHang != null) {
                    for (int i = 0; i < listDonHang.Count;i++ )
                    { 
                 %>
        	        <tr>
                        <td><%=pageSize*(pageId-1)+(i+1) %></td>
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
        
</div><!--@@@@@-->
<!--@@@@@Navigation-->
    <div class="has-text-centered">
        Hiển thị <%=(totalItem==0?0:((pageId*pageSize)-pageSize+1)) %> đến <%=(pageId*pageSize)>totalItem?totalItem:(pageId*pageSize) %> của <%=totalItem %> bản ghi
    </div>
    <nav class="pagination is-centered" role="navigation" aria-label="pagination">
      
      <ul class="pagination-list">
        <asp:Literal ID="ltPage" runat="server"></asp:Literal>
      </ul>
    </nav>
<!--@@@@@EndNavigation-->
