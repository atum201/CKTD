<%@ Page Title="" Language="C#" MasterPageFile="~/OneColumn.master" AutoEventWireup="true" CodeFile="DangKy.aspx.cs" Inherits="Views_Frontend_DangKy" %>

<asp:Content ID="Content1" ContentPlaceHolderID="mainColumn" Runat="Server">
    <script>
        function ValidateDangKy() {
            var result = "";
            if ($('#<%=txtTenDangNhap.ClientID%>').val() == "") {
                result += "Tên đăng nhập không được để trống\n";
            } else {
                if (isExistingAccount()) {
                    result += "Tên đăng nhập đã tồn tại\n";
                }
            }
            if ($('#<%=txtEmail.ClientID%>').val() == "") {
                result += "Email không được để trống\n";
            }
            if ($('#<%=txtMatKhau.ClientID%>').val() == "") {
                result += "Mật khẩu không được để trống\n";
            } else {
                if ($('#<%=txtMatKhau.ClientID%>').val() != $('#<%=txtConfirmMatKhau.ClientID%>').val()) {
                    result += "Mật khẩu và xác nhận mật khẩu phải trùng nhau\n";
                }
            }
            if ($('#<%=txtSoDienThoai.ClientID%>').val() == "") {
                result += "Số điện thoại không được để trống\n";
            }
            
            if (result.length > 0) {
                alert(result);
                return false;
            }
            return true;
            
        }

        function isExistingAccount() {
            var flag = false;
            $.ajax({
                url: '/Views/Frontend/ProcessingAjax.aspx?Command=isExistingAccount&tenDangNhap=' + $("#<%=txtTenDangNhap.ClientID %>").val(),
                type: 'post',
                dataType: 'json',
                async: false,
                success: (function (response) {
                    flag = response.Result;
                })
            });
            return flag;
        }

    </script>
    <div id="scroll_div" class="column is-8 is-offset-2">
   <div class="tabs is-boxed">
      <ul>
         <li class="is-active">
            <a>
            <span class="icon"><img src="/Style/images/icon-user.png" /></span>
            <span>ĐĂNG KÝ</span>
            </a>
         </li>
      </ul>
   </div>
   <form runat="server" class="userAction">
      <div class="formInner">
         <div class="field is-horizontal">
            <div class="field-label">
               <label class="label">Tên đăng nhập</label>
            </div>
            <div class="field-body">
               <div class="field">
                  <div class="control">
                      <asp:TextBox runat="server" ID="txtTenDangNhap" CssClass="input" placeholder="Không được trống"></asp:TextBox>
                  </div>
               </div>
            </div>
         </div>
         <div class="field is-horizontal">
            <div class="field-label">
               <label class="label">Email</label>
            </div>
            <div class="field-body">
               <div class="field">
                  <div class="control">
                     <asp:TextBox runat="server" ID="txtEmail" CssClass="input" placeholder="Không được trống"></asp:TextBox>
                  </div>
               </div>
            </div>
         </div>
         <div class="field is-horizontal">
            <div class="field-label">
               <label class="label">Mật khẩu</label>
            </div>
            <div class="field-body">
               <div class="field">
                  <div class="control">
                     <asp:TextBox runat="server" ID="txtMatKhau" CssClass="input" TextMode="Password" placeholder="Không được trống"></asp:TextBox>
                  </div>
               </div>
            </div>
         </div>
         <div class="field is-horizontal">
            <div class="field-label">
               <label class="label">Xác nhận mật khẩu</label>
            </div>
            <div class="field-body">
               <div class="field">
                  <div class="control">
                     <asp:TextBox runat="server" ID="txtConfirmMatKhau" CssClass="input" TextMode="Password" placeholder="Không được trống"></asp:TextBox>
                  </div>
               </div>
            </div>
         </div>
         <div class="field is-horizontal">
            <div class="field-label">
               <label class="label">Số điện thoại</label>
            </div>
            <div class="field-body">
               <div class="field">
                  <div class="control">
                     <asp:TextBox runat="server" ID="txtSoDienThoai" CssClass="input"  placeholder="Không được trống"></asp:TextBox>
                  </div>
               </div>
            </div>
         </div>
      </div>
      <div class="formFooter continue">
          <asp:Button ID="btnDangKy" CssClass="button" runat="server" OnClientClick="ValidateDangKy()" OnClick="btnDangKy_Click" Text="ĐĂNG KÝ"/>
      </div>
   </form>
</div>
</asp:Content>

