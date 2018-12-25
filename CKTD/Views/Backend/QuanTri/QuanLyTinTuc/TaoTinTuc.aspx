<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Backend/QuanTri/QuanTri.master" AutoEventWireup="true" CodeFile="TaoTinTuc.aspx.cs" Inherits="Views_Backend_QuanTri_QuanLyTinTuc_TaoTinTuc" %>
<asp:Content ID="Content2" ContentPlaceHolderID="cphTabRow" Runat="Server">
    <ul>
        <li class="is-active"><a href="/Views/Backend/QuanTri/QuanLyDonHang/DanhSachDonHang.aspx">Đơn hàng</a></li>
        <li><a href="/Views/Backend/QuanTri/QuanLyLoaiTien/DanhSachLoaiTien.aspx">Loại tiền</a></li>
        <li><a href="/Views/Backend/QuanTri/QuanLyNguoiDung/DanhSachNguoiDung.aspx">Người dùng</a></li>        
        <li><a href="/Views/Backend/QuanTri/QuanLyTaiKhoanNganHang/DanhSachTaiKhoanNganHang.aspx">Tài khoản ngân hàng</a></li>
        <li><a href="/Views/Backend/QuanTri/QuanLyTinTuc/DanhSachTinTuc.aspx">Tin tức</a></li>
        <li><a href="/Views/Backend/QuanTri/CauHinhThongTinHeThong.aspx">Hệ thống</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="cphMainColumn" Runat="Server">
    <script src="/ckeditor/ckeditor.js"></script>
    <script src="/ckfinder/ckfinder.js"></script>
    
    
    <form runat="server">
        <asp:TextBox runat="server" TextMode="MultiLine" Height="100" ID="txtContent"></asp:TextBox>

    </form>

    <script>
        var editor = CKEDITOR.replace('<%=txtContent.ClientID%>');

        CKFinder.setupCKEditor(editor, '/ckfinder');
        <%--var editor = CKEDITOR.replace('<%=txtContent.ClientID%>', {
            filebrowserBrowseUrl: '/ckfinder/ckfinder.html',
            filebrowserImageBrowseUrl: '/ckfinder/ckfinder.html?type=Images',
            filebrowserFlashBrowseUrl: '/ckfinder/ckfinder.html?type=Flash',
            
        });
        CKFinder.setupCKEditor(editor, {
            skin: 'jquery-mobile',
            swatch: 'b',
            onInit: function (finder) {
                finder.on('files:choose', function (evt) {
                    var file = evt.data.files.first();
                    console.log('Selected: ' + file.get('name'));
                });
            }
        });--%>
    </script>

</asp:Content>

