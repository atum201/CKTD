<%@ Page Language="C#" MasterPageFile="~/QuanTri/QuanTri.master" AutoEventWireup="true" CodeFile="QuanLyLienThongCP.aspx.cs" Inherits="QuanTri_QuanLyLienThongCP" %>

<asp:Content ID="ContentLeftColumn" ContentPlaceHolderID="cphLeftColumn" Runat="Server">
    <ul  class="tradeType">
        <li><a href="/QuanTri/CP_SoLieuVanBan.aspx">Số liệu Văn bản</a></li>
        <li><a href="/QuanTri/CP_SoLieuDichVuCong.aspx">Số liệu Dịch vụ công</a></li>
        <li><a href="/QuanTri/CP_XuLyVanBan.aspx">Xử lý Văn bản</a></li>
        <li><a href="/QuanTri/CP_XuLyDichVuCong.aspx">Xử lý Dịch vụ công</a></li>
    </ul>
</asp:Content>
<asp:Content ID="ContentRightColumn" ContentPlaceHolderID="cphRightColumn" Runat="Server">
    Content here
</asp:Content>