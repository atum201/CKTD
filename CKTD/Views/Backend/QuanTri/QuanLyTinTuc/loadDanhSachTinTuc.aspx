<%@ Page Language="C#" AutoEventWireup="true" CodeFile="loadDanhSachTinTuc.aspx.cs" Inherits="Views_Backend_QuanTri_QuanLyTinTuc_loadDanhSachTinTuc" %>

<div id="content">

    <%
        if (listTinTuc != null)
        {
            for (int i = 0; i < listTinTuc.Count; i++)
            { 
    %>
    <tr>
        <td><%=pageSize*(pageId-1)+(i+1) %></td>
        <td><%=listTinTuc[i].TieuDe %></td>
        <td><%=listTinTuc[i].LoaiTinTuc %></td>
        <td><%=listTinTuc[i].NgayTao.Value.ToString("dd-MM-yyyy HH:mm:ss") %></td>
        <td><%=listTinTuc[i].TrangThai %></td>
        <td>
            <a href="/Views/Backend/QuanTri/QuanLyTinTuc/CapNhatTinTuc.aspx?iDTinTuc=<%=listTinTuc[i].ID %>">
                <span class="icon has-text-success">
                    <i class="fa fa-edit"></i>
                </span>
            </a>
            <a href="/Views/Backend/QuanTri/QuanLyTinTuc/XoaTinTuc.aspx?iDTinTuc=<%=listTinTuc[i].ID %>">
                <span class="icon has-text-success">
                    <i class="fa fa-trash"></i>
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
        <asp:literal id="ltPage" runat="server"></asp:literal>
    </ul>
</nav>
<!--@@@@@EndNavigation-->
