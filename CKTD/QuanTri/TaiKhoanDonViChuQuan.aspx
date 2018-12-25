<%@ Page Language="C#" MasterPageFile="~/QuanTri/QuanTri.master" AutoEventWireup="true" CodeFile="TaiKhoanDonViChuQuan.aspx.cs" Inherits="QuanTri_TaiKhoanDonViChuQuan" %>

<asp:Content ID="ContentLeftColumn" ContentPlaceHolderID="cphLeftColumn" Runat="Server">
    <ul  class="tradeType">
        <li><a href="/QuanTri/DanhSachTaiKhoan.aspx">Danh sách tài khoản</a></li>
        <li><a href="/QuanTri/TaiKhoanDonViChuQuan.aspx">Tài khoản đơn vị chủ quản</a></li>
    </ul>
</asp:Content>
<asp:Content ID="ContentRightColumn" ContentPlaceHolderID="cphRightColumn" Runat="Server">
    <b>Danh sách Tài khoản cho Đơn vị chủ quản</b>
    <table class="table">
        <thead>
            <tr>
                <th>STT</th>
                <th>Tên hiển thị</th>
                <th>Tài khoản</th>
                <th>Loại tài khoản</th>
                <th>Trạng thái</th>
                <th>Thời gian cập nhật</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>1</td>
                <td>Admin Cục viễn thông</td>
                <td>cucvienthong</td>
                <td>Đơn vị chủ quản</td>
                <td>Hoạt động</td>
                <td>20/12/2018</td>
            </tr>
        </tbody>
    </table>
</asp:Content>

