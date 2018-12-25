<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Backend/QuanTri/QuanTri.master" AutoEventWireup="true" CodeFile="CapNhatTinTuc.aspx.cs" Inherits="Views_Backend_QuanTri_QuanLyTinTuc_CapNhatTinTuc" %>


<asp:Content ID="Content2" ContentPlaceHolderID="cphTabRow" runat="Server">
    <ul>
        <li><a href="/Views/Backend/QuanTri/QuanLyDonHang/DanhSachDonHang.aspx">Đơn hàng</a></li>
        <li><a href="/Views/Backend/QuanTri/QuanLyLoaiTien/DanhSachLoaiTien.aspx">Loại tiền</a></li>
        <li><a href="/Views/Backend/QuanTri/QuanLyNguoiDung/DanhSachNguoiDung.aspx">Người dùng</a></li>
        <li><a href="/Views/Backend/QuanTri/QuanLyTaiKhoanNganHang/DanhSachTaiKhoanNganHang.aspx">Tài khoản ngân hàng</a></li>
        <li class="is-active"><a href="/Views/Backend/QuanTri/QuanLyTinTuc/DanhSachTinTuc.aspx">Tin tức</a></li>
        <li><a href="/Views/Backend/QuanTri/CauHinhThongTinHeThong.aspx">Hệ thống</a></li>
    </ul>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="cphMainColumn" runat="Server">
    <script src="/ckeditor/ckeditor.js"></script>
    <script src="/ckfinder/ckfinder.js"></script>
    <form runat="server">
        <div id="buyCoin" class="tab-content is-active">

            <div class="formInner">
                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Tiêu đề</label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                                <%--<input class="input" type="text" name="Phone" >--%>
                                <asp:TextBox runat="server" ID="txtTieuDe" CssClass="input"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Nội dung</label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                                <%--<input class="input" type="text" name="Phone" >--%>
                                <asp:TextBox runat="server" TextMode="MultiLine" Height="100" ID="txtNoiDung"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Ngày tạo</label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                                <%--<input class="input" type="text" name="Phone" >--%>
                                <asp:TextBox runat="server" ID="txtNgayTao" CssClass="input"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">loại tin tức</label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                                <%--<input class="input" type="text" name="Phone" >--%>
                                <asp:DropDownList ID="ddlLoaiTinTuc" runat="server" AppendDataBoundItems="true" CssClass="input"></asp:DropDownList>

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
        var editor = CKEDITOR.replace('<%=txtNoiDung.ClientID%>');

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



