<%@ Page Language="C#" MasterPageFile="~/QuanTri/QuanTri.master" AutoEventWireup="true" CodeFile="CapNhatTaiKhoan.aspx.cs" Inherits="QuanTri_CapNhatTaiKhoan" %>

<script runat="server">

    protected void btnQuayLai_Click(object sender, EventArgs e)
    {

    }
</script>

<asp:Content ID="ContentLeftColumn" ContentPlaceHolderID="cphLeftColumn" Runat="Server">
    <ul  class="tradeType">
        <li><a href="/QuanTri/DanhSachTaiKhoan.aspx">Danh sách tài khoản</a></li>
        <li><a href="/QuanTri/TaiKhoanDonViChuQuan.aspx">Tài khoản đơn vị chủ quản</a></li>
    </ul>
</asp:Content>
<asp:Content ID="ContentRightColumn" ContentPlaceHolderID="cphRightColumn" Runat="Server">
    <form runat="server">
        <div id="buyCoin" class="tab-content is-active">
         
             <div class="formInner">
                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Tên hiển thị</label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                                
                                <asp:TextBox runat="server"  ID="txtTenHienThi" CssClass="input"></asp:TextBox>
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
                               
                                <asp:TextBox runat="server" ID="txtTenDangNhap" CssClass="input"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
              <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Loại tài khoản</label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                               
                                <asp:DropDownList CssClass="input" runat="server">
                                    <asp:ListItem>Quản trị</asp:ListItem>
                                    <asp:ListItem>Đơn vị trực thuộc</asp:ListItem>
                                    <asp:ListItem>Khác</asp:ListItem>
                                </asp:DropDownList>
                             
                            </div>
                        </div>
                    </div>
                </div>
                <div class="formFooter columns is-alignCenter">
                    <div class="column continue">
                        <%--<button type="button" class="subfrm button continue">Tiếp tục</button>--%>

                        <asp:Button runat="server" ID="btnCapNhat" CssClass="subfrm button continue" Text="Cập Nhật" OnClientClick="return ValidateNumber()" OnClick="btnCapNhat_Click" />
                        <asp:Button runat="server" ID="btnQuayLai" CssClass="subfrm button continue" Text="Trở về" OnClick="btnQuayLai_Click" />
                    </div>
                </div>
            </div>
            </div>
    </form>
    <script>

        function ValidateNumber() {
            var result = "";

            if (!isFloat(Number($("input[id*='TxtHanMucTrongNgay']").val()))) {
                result += "Hạn mức tài khoản vui lòng nhập kiểu số\n";
            }

            if (result == "") {
                return true;
            }
            alert(result);
            return false;
        }
    </script>
</asp:Content>