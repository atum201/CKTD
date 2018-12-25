<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Backend/QuanTri/QuanTri.master" AutoEventWireup="true" CodeFile="CapNhatDonHang.aspx.cs" Inherits="Views_Backend_QuanTri_QuanLyDonHang_CapNhatDonHang" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphTabRow" runat="Server">
    <ul>
        <li class="is-active"><a href="/Views/Backend/QuanTri/QuanLyDonHang/DanhSachDonHang.aspx">Đơn hàng</a></li>
        <li><a href="/Views/Backend/QuanTri/QuanLyLoaiTien/DanhSachLoaiTien.aspx">Loại tiền</a></li>
        <li><a href="/Views/Backend/QuanTri/QuanLyNguoiDung/DanhSachNguoiDung.aspx">Người dùng</a></li>
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
                        <label class="label">Mã giao dịch</label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                                <%--<input class="input" type="text" name="Phone" >--%>
                                <asp:TextBox runat="server" ID="txtMaGiaoDich" CssClass="input" Enabled="false"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">loại giao dịch</label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                                <%--<input class="input" type="text" name="Phone" >--%>
                                <asp:TextBox runat="server" ID="txtLoaiGiaoDich" CssClass="input" Enabled="false"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Loại tiền</label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                                <%--<input class="input" type="text" name="Phone" >--%>
                                <asp:TextBox runat="server" ID="txtLoaiTien" CssClass="input" Enabled="false"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Số lượng</label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                                <%--<input class="input" type="text" name="Phone" >--%>
                                <asp:TextBox runat="server" ID="txtSoLuong" CssClass="input" Enabled="false"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Giá trị</label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                                <%--<input class="input" type="text" name="Phone" >--%>
                                <asp:TextBox runat="server" ID="txtGiaTri" CssClass="input" Enabled="false"></asp:TextBox>
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

                <%=(donHang.LoaiDonHang=="KhachBan")?"<!--":"" %>

                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Địa chỉ ví tiền</label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                                <asp:TextBox runat="server" ID="txtDiaChiViTien" CssClass="input" Enabled="false"></asp:TextBox>
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
                                <asp:TextBox runat="server" ID="txtSoDienThoai" CssClass="input" Enabled="false"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                <%=(donHang.LoaiDonHang=="KhachBan")?"-->":"" %>

                <%=(donHang.LoaiDonHang=="KhachMua")?"<!--":"" %>
                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Tài khoản ngân hàng</label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                                <asp:TextBox runat="server" ID="txtTaiKhoanNganHang" CssClass="input" Enabled="false"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Số tài khoản người bán</label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                                <asp:TextBox runat="server" ID="txtSoTaiKhoanNguoiBan" CssClass="input" Enabled="false"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Tên chủ tài khoản</label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                                <asp:TextBox runat="server" ID="txtTenChuTaiKhoan" CssClass="input" Enabled="false"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Mã địa chỉ ví giao dịch</label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                                <asp:TextBox runat="server" ID="txtMaDiaChiViGiaoDich" CssClass="input" Enabled="false"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                <%=(donHang.LoaiDonHang=="KhachMua")?"-->":"" %>



                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Hoa hồng người giới thiệu</label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                                <%--<input class="input" type="text" name="Phone" >--%>
                                <asp:TextBox runat="server" ID="txtHoaHongNguoiGioiThieu" CssClass="input" Enabled="false"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Ngày tạo đơn hàng</label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                                <%--<input class="input" type="text" name="Phone" >--%>
                                <asp:TextBox runat="server" ID="txtNgayTaoDonHang" CssClass="input" Enabled="false"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label"><%=donHang.LoaiDonHang=="KhachMua"?"Ngày chuyển coin":"Ngày thanh toán" %></label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                                <%--<input class="input" type="text" name="Phone" >--%>
                                <asp:TextBox runat="server" ID="txtNgayThanhToan" CssClass="input" Enabled="false"></asp:TextBox>
                            </div>
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
    </form>
    <script>
        $("#<%=ddlTrangThai.ClientID %>").bind("change", function () {
            if ($("#<%=ddlTrangThai.ClientID %>").val() == "") {
                $("#<%=txtHoaHongNguoiGioiThieu.ClientID %>").val("<%=hoaHongNguoiGioiThieu%>");
            } else {
                $("#<%=txtHoaHongNguoiGioiThieu.ClientID %>").val("0");
            }
        });

    </script>
</asp:Content>

