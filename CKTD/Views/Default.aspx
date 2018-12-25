<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Views_Default" %>

<%-- Add content controls here --%>
<asp:Content ID="ContentLeftColumn" ContentPlaceHolderID="cphLeftColumn" Runat="Server">
    <ul class="tradeType">
        <%
            if (listLoaiTien != null) 
            {
                foreach (var loaiTien in listLoaiTien) 
                {  
             %>
                    <li><a href="/Views/Frontend/MuaBanCoin.aspx?idLoaiTien=<%=loaiTien.ID %>">Giao dịch <%=loaiTien.TenLoaiTien %></a></li>
        <%
                }
            }
           %>
        
    </ul>
</asp:Content>

<asp:Content ID="ContentRighetColumn" ContentPlaceHolderID="cphRightColumn" Runat="Server">
    <form id="form1" runat="server">
    </form>
</asp:Content>

