<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Backend/QuanTri/QuanTri.master" AutoEventWireup="true" CodeFile="CapNhatNguoiDung.aspx.cs" Inherits="Views_Backend_QuanTri_QuanLyNguoiDung_CapNhatNguoiDung" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphTabRow" runat="Server">
    <ul>
        <li><a href="/Views/Backend/QuanTri/QuanLyDonHang/DanhSachDonHang.aspx">Đơn hàng</a></li>
        <li><a href="/Views/Backend/QuanTri/QuanLyLoaiTien/DanhSachLoaiTien.aspx">Loại tiền</a></li>
        <li class="is-active"><a href="/Views/Backend/QuanTri/QuanLyNguoiDung/DanhSachNguoiDung.aspx">Người dùng</a></li>
        <li><a href="/Views/Backend/QuanTri/QuanLyTaiKhoanNganHang/DanhSachTaiKhoanNganHang.aspx">Tài khoản ngân hàng</a></li>
        <li><a href="/Views/Backend/QuanTri/QuanLyTinTuc/DanhSachTinTuc.aspx">Tin tức</a></li>
        <li><a href="/Views/Backend/QuanTri/CauHinhThongTinHeThong.aspx">Hệ thống</a></li>
    </ul>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="cphMainColumn" runat="Server">
    <form runat="server">
        <div id="buyCoin" class="tab-content is-active">

            <div class="formInner">
                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Họ tên</label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                                <%--<input class="input" type="text" name="Phone" >--%>
                                <asp:TextBox runat="server" ID="txtHoTen" CssClass="input"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Tên đăng nhập</label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                                <%--<input class="input" type="text" name="Phone" >--%>
                                <asp:TextBox runat="server" ID="txtTenDangNhap" CssClass="input" Enabled="false"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                  <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Mật khẩu</label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                                <%--<input class="input" type="text" name="Phone" >--%>
                                <asp:TextBox runat="server" type="password"  ID="txtMatKhau" CssClass="input" ></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Ngày sinh</label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                                <%--<input class="input" type="text" name="Phone" >--%>
                                <asp:TextBox runat="server" ID="txtNgaySinh" CssClass="input"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Số CMT</label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                                <%--<input class="input" type="text" name="Phone" >--%>
                                <asp:TextBox runat="server" ID="txtSoCMT" CssClass="input"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Email</label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                                <%--<input class="input" type="text" name="Phone" >--%>
                                <asp:TextBox runat="server" ID="txtEmail" CssClass="input"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>


                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Số điện thoại</label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                                <asp:TextBox runat="server" ID="txtSoDienThoai" CssClass="input"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">loại người dùng</label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                                <%--<input class="input" type="text" name="Phone" >--%>
                                <asp:DropDownList ID="ddlLoaiNguoiDung" runat="server" AppendDataBoundItems="true" CssClass="input"></asp:DropDownList>

                            </div>
                        </div>
                    </div>
                </div>

                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Trạng thái</label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                                <%--<input class="input" type="text" name="Phone" >--%>
                                <asp:DropDownList ID="ddlTrangThai" runat="server" AppendDataBoundItems="true" CssClass="input"></asp:DropDownList>

                            </div>
                        </div>
                    </div>
                </div>
                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Người giới thiệu</label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                                <%--<input class="input" type="text" name="Phone" >--%>
                                <asp:TextBox runat="server" ID="txtNguoiGioiThieu" CssClass="input" Enabled="false"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="formFooter columns is-alignCenter">
                    <div class="column continue">
                        <%--<button type="button" class="subfrm button continue">Tiếp tục</button>--%>

                        <asp:Button runat="server" ID="btnCapNhat" CssClass="subfrm button continue" Text="Cập nhật" OnClick="btnCapNhat_Click" />
                        <asp:Button runat="server" ID="btnQuayLai" CssClass="subfrm button continue" Text="Trở về" OnClick="btnQuayLai_Click" />
                    </div>
                </div>
            </div>
            </div>
    </form>
    <script>
        <%--   $("#<%=ddlTrangThai.ClientID %>").bind("change", function () {
            if ($("#<%=ddlTrangThai.ClientID %>").val() == "") {
                $("#<%=txtHoaHongNguoiGioiThieu.ClientID %>").val("<%=hoaHongNguoiGioiThieu%>");
            } else {
                $("#<%=txtHoaHongNguoiGioiThieu.ClientID %>").val("0");
            }
        });--%>

    </script>
</asp:Content>

