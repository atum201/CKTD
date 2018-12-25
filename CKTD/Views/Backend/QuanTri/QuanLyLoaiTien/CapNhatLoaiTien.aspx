<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Backend/QuanTri/QuanTri.master" AutoEventWireup="true" CodeFile="CapNhatLoaiTien.aspx.cs" Inherits="Views_Backend_QuanTri_QuanLyLoaiTien_CapNhatLoaiTien" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphTabRow" runat="Server">
    <ul>
        <li><a href="/Views/Backend/QuanTri/QuanLyDonHang/DanhSachDonHang.aspx">Đơn hàng</a></li>
        <li class="is-active"><a href="/Views/Backend/QuanTri/QuanLyLoaiTien/DanhSachLoaiTien.aspx">Loại tiền</a></li>
        <li ><a href="/Views/Backend/QuanTri/QuanLyNguoiDung/DanhSachNguoiDung.aspx">Người dùng</a></li>
        <li><a href="/Views/Backend/QuanTri/QuanLyTaiKhoanNganHang/DanhSachTaiKhoanNganHang.aspx">Tài khoản ngân hàng</a></li>
        <li><a href="/Views/Backend/QuanTri/QuanLyTinTuc/DanhSachTinTuc.aspx">Tin tức</a></li>
        <li><a href="/Views/Backend/QuanTri/CauHinhThongTinHeThong.aspx">Hệ thống</a></li>
    </ul>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="cphMainColumn" runat="Server">
    <form runat="server">
        <div id="buyCoin" class="tab-content is-active">

            <div class="formInner">
                 <div id="buyCoin" class="tab-content is-active">
            
            <div class="formInner">
                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Loại tiền tệ</label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">

                                <asp:TextBox runat="server" ID="txtTenLoaiTien" onkeyup="this.value=this.value.toUpperCase()" CssClass="input"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Mã tiền </label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                                <asp:TextBox runat="server" ID="txtMaLoaiTien" CssClass="input"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Giá mua </label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">

                                <asp:TextBox runat="server" ID="txtGiaMua" CssClass="input"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Phụ phí mua </label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">

                                <asp:TextBox runat="server" ID="txtPhuPhiMua" CssClass="input"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>


                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Giá bán </label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">

                                <asp:TextBox runat="server" ID="txtGiaBan" CssClass="input"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Phụ phí bán </label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">

                                <asp:TextBox runat="server" ID="txtPhuPhiBan" CssClass="input"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Hạn mức </label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">

                                <asp:TextBox runat="server" ID="txtHanMuc" CssClass="input"></asp:TextBox>

                            </div>
                        </div>
                    </div>
                </div>
                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Thông báo hết hạn mức </label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">

                                <asp:TextBox runat="server" ID="txtThongBaoHetHanMuc" CssClass="input"></asp:TextBox>

                            </div>
                        </div>
                    </div>
                </div>
                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Thứ tự meu dọc  </label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                                <asp:TextBox runat="server" ID="txtThuTu" ToolTip="Thứ tự menu dọc" CssClass="input"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Ảnh icon</label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                              <span class="control"> <asp:FileUpload ID="filelinkicon" AllowMultiple="false" runat="server" /></span>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Autoload</label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                                <%--<input class="input" type="text" name="Phone" >--%>
                                <asp:DropDownList ID="ddlAutoLoad" runat="server" AppendDataBoundItems="true" CssClass="input"></asp:DropDownList>

                            </div>
                        </div>
                    </div>
                </div>
                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Hiển thị lên menu ngang</label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                                <%--<input class="input" type="text" name="Phone" >--%>
                                <asp:CheckBox ID="chkHienThiBox" runat="server"></asp:CheckBox>

                            </div>
                        </div>
                    </div>
                </div>

                <div id="pnlContent" class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Thứ tự hiển thị menu ngang  </label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                                <asp:TextBox runat="server" ID="txtThuTuHienThiBox" ToolTip="Thứ tự menu ngang" CssClass="input"></asp:TextBox>
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
            </div>
                <div class="formFooter columns is-alignCenter">
                    <div class="column continue">
                        <%--<button type="button" class="subfrm button continue">Tiếp tục</button>--%>

                        <asp:Button runat="server" ID="btnCapNhat" CssClass="subfrm button continue" Text="Cập nhật" OnClientClick="return Validate()" OnClick="btnCapNhat_Click" />
                        <asp:Button runat="server" ID="btnQuayLai" CssClass="subfrm button continue" Text="Trở về" OnClick="btnQuayLai_Click" />
                    </div>
                </div>
            </div>
            </div>
    </form>
    <script>

        function Validate() {
            var result = "";
            if ($("input[id*='txtTenLoaiTien']").val() == "") {
                result += "Loại tiền không được trống\n";
            }
            if ($("input[id*='txtMaLoaiTien']").val() == "") {
                result += "Loại tiền không được trống\n";
            }
            if ($("input[id*='txtGiaMua']").val() == "") {
                result += "Giá mua không được trống\n";
            }
            else {
                if (!isFloat(Number($("input[id*='txtGiaMua']").val()))) {
                    result += "Giá mua vui lòng nhập kiểu số\n";
                }
            }
            if (!isFloat(Number($("input[id*='txtPhuPhiMua']").val()))) {
                result += "Phụ phí mua vui lòng nhập kiểu số\n";
            }
            if ($("input[id*='txtGiaBan']").val() == "") {
                result += "Giá bán không được trống\n";
            }
            else {
                if (!isFloat(Number($("input[id*='txtGiaBan']").val()))) {
                    result += "Giá bán vui lòng nhập kiểu số\n";
                }
            }
            if (!isFloat(Number($("input[id*='txtPhuPhiBan']").val()))) {
                result += "Phụ phí bán vui lòng nhập kiểu số\n";
            }
            if ($("input[id*='txtHanMuc']").val() != "") {
                // alert($("input[id*='txtHanMuc']").val());
                if (!isFloat(Number($("input[id*='txtHanMuc']").val()))) {
                    result += "Hạn mức vui lòng nhập kiểu số\n";
                }
                if ($("input[id*='txtThongBaoHetHanMuc']").val() == "") {
                    result += "Thông báo hết hạn mức không được trống\n";
                }
            }
            if (!isFloat(Number($("input[id*='txtThuTu']").val()))) {
                result += "Thứ tự vui lòng nhập kiểu số\n";
            }
            if (!isFloat(Number($("input[id*='txtThuTuHienThiBox']").val()))) {
                result += "Thứ tự vui lòng nhập kiểu số\n";
            }
            if (result == "") {
                return true;
            }
            alert(result);
            return false;
        }

        $(document).ready(function () {

            var chkControl = document.getElementById('<%= chkHienThiBox.ClientID %>');
            $("#pnlContent").css("display", "none");
            $(chkControl).click(function () {
                if ($(chkControl).is(":checked")) {
                    $("#pnlContent").show("slow");
                }
                else {
                    $("#pnlContent").hide("slow");
                }
            });
        });
    </script>
</asp:Content>

