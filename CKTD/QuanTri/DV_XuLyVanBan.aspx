<%@ Page Language="C#" MasterPageFile="~/QuanTri/QuanTri.master" AutoEventWireup="true" CodeFile="DV_XuLyVanBan.aspx.cs" Inherits="QuanTri_DV_XuLyVanBan" %>

<asp:Content ID="ContentLeftColumn" ContentPlaceHolderID="cphLeftColumn" Runat="Server">
    <ul class="tradeType">
        <li><a href="/QuanTri/DanhSachDonVi.aspx">Danh sách đơn vị chủ quản</a></li>
        <li><a href="/QuanTri/DV_XuLyVanBan.aspx">Văn bản trao đổi</a></li>
        <li><a href="/QuanTri/DV_DichVuCongBac3.aspx">Dịch vụ công bậc 3</a></li>
        <li><a href="/QuanTri/DV_DichVuCongBac4.aspx">Dịch vụ công bậc 4</a></li>
    </ul>
</asp:Content>
<asp:Content ID="ContentRightColumn" ContentPlaceHolderID="cphRightColumn" Runat="Server">
    <b>Danh sách văn bản trao đổi - Đơn vị chủ quản</b>
    <table class="table">
        <thead>
            <tr>
                <th>Tên đơn vị</th>
                <th>Tổng số văn bản trao đổi</th>
                <th>Thời gian cập nhật</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>Cục viễn thông</td>
                <td>1000</td>
                <td>25/12/2018</td>
            </tr>
        </tbody>
    </table>
</asp:Content>
