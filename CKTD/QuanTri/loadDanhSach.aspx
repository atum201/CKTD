<%@ Page Language="C#" AutoEventWireup="true" CodeFile="loadDanhSach.aspx.cs" Inherits="QuanTri_loadDanhSach" %>

<div id="content">
    <%=DanhSachContent %>
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

