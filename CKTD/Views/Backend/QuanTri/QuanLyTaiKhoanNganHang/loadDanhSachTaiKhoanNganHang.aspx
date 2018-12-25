<%@ Page Language="C#" AutoEventWireup="true" CodeFile="loadDanhSachTaiKhoanNganHang.aspx.cs" Inherits="Views_Backend_QuanTri_QuanLyTaiKhoanNganHang_loadDanhSachTaiKhoanNganHang" %>

<div id="content">
                
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
