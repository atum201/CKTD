<%@ Page Language="C#" MasterPageFile="~/QuanTri/QuanTri.master" AutoEventWireup="true" CodeFile="DV_DichVuCongBac3.aspx.cs" Inherits="QuanTri_DV_DichVuCongBac3" %>
<asp:Content ID="ContentLeftColumn" ContentPlaceHolderID="cphLeftColumn" Runat="Server">
    <ul class="tradeType">
        <li><a href="/QuanTri/DanhSachDonVi.aspx">Danh sách đơn vị chủ quản</a></li>
        <li><a href="/QuanTri/DV_XuLyVanBan.aspx">Văn bản trao đổi</a></li>
        <li><a href="/QuanTri/DV_DichVuCongBac3.aspx">Dịch vụ công bậc 3</a></li>
        <li><a href="/QuanTri/DV_DichVuCongBac4.aspx">Dịch vụ công bậc 4</a></li>
    </ul>
</asp:Content>
<asp:Content ID="ContentRightColumn" ContentPlaceHolderID="cphRightColumn" Runat="Server">
    <b>Danh sách Dịch vụ công bậc 3 - Đơn vị chủ quản</b>
    <table class="table">
        <thead>
            <tr>
                <th>Tên dịch vụ</th>
                <th>Đơn vị</th>
                <th>Hồ sơ tiếp nhận</th>
                <th>Hồ sơ đã xử lý</th>
                <th>Hồ sơ xử lý đúng hạn</th>
                <th>Tỉ lệ đúng hạn</th>
                <th>Thời gian cập nhật</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>Cấp giấy Chứng nhận hợp quy</td>
                <td>Cục viễn thông</td>
                <td>15132</td>
                <td>15121</td>
                <td>15005</td>
                <td>90%</td>
                <td>20/12/2018</td>
            </tr>
        </tbody>
    </table>
</asp:Content>