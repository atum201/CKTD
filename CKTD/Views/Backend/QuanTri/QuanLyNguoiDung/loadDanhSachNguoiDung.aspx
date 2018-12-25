<%@ Page Language="C#" AutoEventWireup="true" CodeFile="loadDanhSachNguoiDung.aspx.cs" Inherits="Views_Backend_QuanTri_QuanLyNguoiDung_loadDanhSachNguoiDung" %>

<div id="content">
                
           <%
                if (listNguoiDung != null) {
                    for (int i = 0; i < listNguoiDung.Count; i++)
                    { 
                 %>
        	        <tr>
                        <td><%=pageSize*(pageId-1)+(i+1) %></td>
                        <td><%=listNguoiDung[i].TenDangNhap %></td>
                        <td><%=listNguoiDung[i].HoTen %></td>
                        <td><%=listNguoiDung[i].LoaiNguoiDung %></td>
                        <td><%=listNguoiDung[i].SoCMT??"" %></td>
                        <td><%=listNguoiDung[i].Email??"" %></td>
                        <td><%=listNguoiDung[i].SoDienThoai??"" %></td>
                        <td><%=listNguoiDung[i].NguoiDungGioiThieu!=null?listNguoiDung[i].NguoiDungGioiThieu.TenDangNhap:"không có" %></td>
                        <td>
                            <a href="/Views/Backend/QuanTri/QuanLyNguoiDung/CapNhatNguoiDung.aspx?iDNguoiDung=<%=listNguoiDung[i].ID %>">
                                <span class="icon has-text-success">
                                    <i class="fa fa-edit"></i>
                                </span>
                            </a>
                            <a href="/Views/Backend/QuanTri/QuanLyNguoiDung/XoaNguoiDung.aspx?iDNguoiDung=<%=listNguoiDung[i].ID %>">
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