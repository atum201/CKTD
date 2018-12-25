<%@ Page Language="C#" MasterPageFile="~/QuanTri/QuanTri.master" AutoEventWireup="true" CodeFile="DanhSachDonVi.aspx.cs" Inherits="QuanTri_DanhSachDonVi" %>

<asp:Content ID="ContentLeftColumn" ContentPlaceHolderID="cphLeftColumn" Runat="Server">
    <ul class="tradeType">
        <li><a href="/QuanTri/DanhSachDonVi.aspx">Danh sách đơn vị chủ quản</a></li>
        <li><a href="/QuanTri/DV_XuLyVanBan.aspx">Văn bản trao đổi</a></li>
        <li><a href="/QuanTri/DV_DichVuCongBac3.aspx">Dịch vụ công bậc 3</a></li>
        <li><a href="/QuanTri/DV_DichVuCongBac4.aspx">Dịch vụ công bậc 4</a></li>
    </ul>
</asp:Content>
<asp:Content ID="ContentRightColumn" ContentPlaceHolderID="cphRightColumn" Runat="Server">
    <b>Danh sách Đơn vị chủ quản</b>
    <table class="table">
        <thead>
            <tr>
                <th>STT</th>
                <th>Tên đơn vị</th>
                <th>Tài khoản</th>
                <th>Địa chỉ</th>
                <th>Email</th>
                <th>Điện thoại</th>
                <th>Trạng thái</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>1</td>
                <td>Cục viễn thông</td>
                <td>cucvienthong</td>
                <td>Cầu Giấy, Hà Nội</td>
                <td>vanthu@cucvienthong.gov.vn</td>
                <td>02431326546</td>
                <td>Hoạt động</td>
            </tr>
        </tbody>
    </table>
</asp:Content>