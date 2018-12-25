<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Backend/QuanTri/QuanTri.master" AutoEventWireup="true" CodeFile="TaoMoiTaiKhoan.aspx.cs" Inherits="Views_Backend_QuanTri_QuanLyTaiKhoanNganHang_TaoMoiTaiKhoan" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphTabRow" runat="Server">
    <ul>
        <li><a href="/Views/Backend/QuanTri/QuanLyDonHang/DanhSachDonHang.aspx">Đơn hàng</a></li>
        <li><a href="/Views/Backend/QuanTri/QuanLyLoaiTien/DanhSachLoaiTien.aspx">Loại tiền</a></li>
        <li><a href="/Views/Backend/QuanTri/QuanLyNguoiDung/DanhSachNguoiDung.aspx">Người dùng</a></li>
        <li class="is-active"><a href="/Views/Backend/QuanTri/QuanLyTaiKhoanNganHang/DanhSachTaiKhoanNganHang.aspx">Tài khoản ngân hàng</a></li>
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
                        <label class="label">Tên Chủ Thẻ</label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                                
                                <asp:TextBox runat="server"  ID="txtTenChuThe" onkeyup="this.value=this.value.toUpperCase()" CssClass="input"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                 
                <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Số tài khoản</label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                               
                                <asp:TextBox runat="server" ID="txtSoTaiKhoan" CssClass="input"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
              <div class="field is-horizontal is-alignCenter">
                    <div class="field-label">
                        <label class="label">Hạn mức trong ngày</label>
                    </div>
                    <div class="field-body">
                        <div class="field">
                            <div class="control">
                               
                                <asp:TextBox runat="server" ID="TxtHanMucTrongNgay"   CssClass="input"   ></asp:TextBox>
                             
                            </div>
                        </div>
                    </div>
                </div>
                <div class="formFooter columns is-alignCenter">
                    <div class="column continue">
                        <%--<button type="button" class="subfrm button continue">Tiếp tục</button>--%>

                        <asp:Button runat="server" ID="btnLuu" CssClass="subfrm button continue" Text="Lưu lại" OnClientClick="return ValidateNumber()" OnClick="btnLuu_Click" />
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

