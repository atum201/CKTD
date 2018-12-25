<%@ Page Language="C#" AutoEventWireup="true" CodeFile="loadDanhSachLoaiTien.aspx.cs" Inherits="Views_Backend_QuanTri_QuanLyLoaiTien_loadDanhSachLoaiTien" %>

<div id="content">
                
           <%
                if (listLoaiTien != null) {
                    for (int i = 0; i < listLoaiTien.Count; i++)
                    { 
                 %>
        	        <tr>
                        <td><%=pageSize*(pageId-1)+(i+1) %></td>
                        <td><%=listLoaiTien[i].TenLoaiTien %></td>
                        <td><%=listLoaiTien[i].AutoLoad %></td>
                        <td><%=listLoaiTien[i].HanMuc.Value.ToString("0.00") %></td>
                        <td><%=listLoaiTien[i].TrangThai %></td>
                        <td>
                            <a href="/Views/Backend/QuanTri/QuanLyLoaiTien/CapNhatLoaiTien.aspx?iDLoaiTien=<%=listLoaiTien[i].ID %>">
                                <span class="icon has-text-success">
                                    <i class="fa fa-edit"></i>
                                </span>
                            </a>
                            <a href="/Views/Backend/QuanTri/QuanLyLoaiTien/XoaLoaiTien.aspx?iDLoaiTien=<%=listLoaiTien[i].ID %>">
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
