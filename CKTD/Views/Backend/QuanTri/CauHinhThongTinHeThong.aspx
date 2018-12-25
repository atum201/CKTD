<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Backend/QuanTri/QuanTri.master" AutoEventWireup="true" CodeFile="CauHinhThongTinHeThong.aspx.cs" Inherits="Views_Backend_QuanTri_CauHinhThongTinHeThong" %>
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
    <form id="form1" runat="server">

    <script>
        jQuery(document).ready(function () {
            var curUrl=window.location.href;
            $.ajax({
                url: 'https://tiktakbtc.com/api/check?bank=VCB&sotk=0491000039353',
                type: 'post',
                dataType: 'html',
                
                success: (function (html) {
                    alert(html);
                })
            });
        });
    </script>
    <div id="rightColumn" class="tab-content is-active">
        <div class="formInner">
            <div class="field is-horizontal is-alignCenter">
                <div class="field-label">
                <label class="label">Thay đổi Logo</label>
                </div>
                <div class="field-body">
                <div class="field">
                    <div class="control">
                        <asp:FileUpload ID="fileLogo" AllowMultiple="false" runat="server"/>
                    </div>
                </div>
                </div>
            </div>
            <div class="field is-horizontal is-alignCenter">
                <div class="field-label">
                <label class="label">Thay đổi Banner</label>
                </div>
                <div class="field-body">
                <div class="field">
                    <div class="control">
                        <asp:FileUpload ID="fileBanner" AllowMultiple="false" runat="server" />
                    </div>
                </div>
                </div>
            </div>
            <div class="field is-horizontal is-alignCenter">
                <div class="field-label">
                <label class="label">Múi giờ</label>
                </div>
                <div class="field-body">
                <div class="field">
                    <div class="select">
                        <asp:DropDownList ID="ddlTimeZone"  runat="server" AppendDataBoundItems="true" CssClass="input"></asp:DropDownList>
                    </div>
                </div>
                </div>
            </div>
            <div class="field is-horizontal is-alignCenter">
                <div class="field-label">
                <label class="label">Hotline</label>
                </div>
                <div class="field-body">
                <div class="field">
                    <div class="control">
                        <asp:TextBox ID="txtHotLine" CssClass="input" runat="server" placeholder="số điện thoại liên hệ"></asp:TextBox>
                    </div>
                </div>
                </div>
            </div>
            <div class="field is-horizontal is-alignCenter">
                <div class="field-label">
                <label class="label">Link facebook</label>
                </div>
                <div class="field-body">
                <div class="field">
                    <div class="control">
                        <asp:TextBox ID="txtLinkFacebook" CssClass="input" runat="server" placeholder="nhập link facebook đại diện"></asp:TextBox>
                    </div>
                </div>
                </div>
            </div>
            <div class="field is-horizontal is-alignCenter">
                <div class="field-label">
                <label class="label">Link youtube</label>
                </div>
                <div class="field-body">
                <div class="field">
                    <div class="control">
                        <asp:TextBox ID="txtLinkYoutube" CssClass="input" runat="server" placeholder="nhập link facebook đại diện"></asp:TextBox>
                    </div>
                </div>
                </div>
            </div>
            <div class="field is-horizontal is-alignCenter">
                <div class="field-label">
                <label class="label">Link Reddit</label>
                </div>
                <div class="field-body">
                <div class="field">
                    <div class="control">
                        <asp:TextBox ID="txtLinkReddit" CssClass="input" runat="server" placeholder="nhập link facebook đại diện"></asp:TextBox>
                    </div>
                </div>
                </div>
            </div>
            <div class="field is-horizontal is-alignCenter">
                <div class="field-label">
                <label class="label">Link LinkedIn</label>
                </div>
                <div class="field-body">
                <div class="field">
                    <div class="control">
                        <asp:TextBox ID="txtLinkLinkedIn" CssClass="input" runat="server" placeholder="nhập link facebook đại diện"></asp:TextBox>
                    </div>
                </div>
                </div>
            </div>

            <div class="field is-horizontal is-alignCenter">
                <div class="field-label">
                <label class="label">Footer</label>
                </div>
                <div class="field-body">
                <div class="field">
                    <div class="control">
                        <asp:TextBox ID="txtFooter" CssClass="input" runat="server" placeholder="mô tả footer" TextMode="MultiLine" Height="100px"></asp:TextBox>
                    </div>
                </div>
                </div>
            </div>

            <div class="field is-horizontal is-alignCenter">
                <div class="field-label">
                <label class="label">Link giới thiệu</label>
                </div>
                <div class="field-body">
                <div class="field">
                    <div class="control">
                        <asp:TextBox ID="txtLinkGioiThieu" CssClass="input" runat="server" placeholder="nhập link giới thiệu"></asp:TextBox>
                    </div>
                </div>
                </div>
            </div>

            <div class="field is-horizontal is-alignCenter">
                <div class="field-label">
                <label class="label">Giá trị kích hoạt hoa hồng</label>
                </div>
                <div class="field-body">
                <div class="field">
                    <div class="control">
                        <asp:TextBox ID="txtGiaTriKichHoatHoaHong" CssClass="input" runat="server" placeholder="nhập giá trị kích hoạt hoa hồng"></asp:TextBox>
                    </div>
                </div>
                </div>
            </div>

            <div class="field is-horizontal is-alignCenter">
                <div class="field-label">
                <label class="label">Tỉ lệ % chia hoa hồng</label>
                </div>
                <div class="field-body">
                <div class="field">
                    <div class="control">
                        <asp:TextBox ID="txtTiLeChiaHoaHong" CssClass="input" runat="server" placeholder="nhập tỉ lệ chia hoa hồng"></asp:TextBox>
                    </div>
                </div>
                </div>
            </div>

        </div>
        <div class="formFooter columns is-alignCenter">
            <div class="column continue">
            </div>
        </div>
        <div class="formFooter columns is-alignCenter">
            <div class="column">
                <asp:Button CssClass="subfrm button" ID="btnLuuLai" OnClick="btnLuuLai_Click" runat="server" Text="Lưu lại"/>
            </div>
        </div>
    </div>
    </form>
</asp:Content>

