<%@ Page Title="" Language="C#" MasterPageFile="~/OneColumn.master" AutoEventWireup="true" CodeFile="DangNhap.aspx.cs" Inherits="Views_Frontend_DangNhap" %>


<asp:Content ID="Content2" ContentPlaceHolderID="mainColumn" Runat="Server">
    
    <div id="scroll_div" class="column is-8 is-offset-2">
                        <div class="tabs is-boxed">
                           <ul>
                              <li class="is-active">
                                 <a>
                                 <span class="icon"><img src="/Style/images/icon-user.png" /></span>
                                 <span>ĐĂNG NHẬP</span>
                                 </a>
                              </li>
                           </ul>
                        </div>
        <form id="form1" runat="server" class="userAction">
                        <div class="formInner">
                           <div class="field is-horizontal">
                              <div class="field-label">
                                 <label class="label">Tên đăng nhập</label>
                              </div>
                              <div class="field-body">
                                 <div class="field">
                                    <div class="control">
                                        <asp:TextBox runat="server" CssClass="input" ID="txtTenDangNhap" placeholder="Không được trống và phải lớn hơn 6 ký tự"></asp:TextBox>
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
                                        <asp:TextBox runat="server" CssClass="input" ID="txtPassword" TextMode="Password" placeholder="Không được trống và phải lớn hơn 6 ký tự"></asp:TextBox>
                                    </div>
                                 </div>
                              </div>
                           </div>
                        </div>
                        <div class="formFooter columns is-alignCenter">
                           <div class="column is-3">
                              <small>
                              <a href="/Views/Frontend/DangKy.aspx"><ins>Đăng ký</ins></a>
                              </small>
                           </div>
                           <div class="column is-6">
                              <small>
                              <a href="https://tiktakbtc.com/mem/reset-password"><ins>Quên mật khẩu</ins></a>
                              </small>
                           </div>
                           <div class="column">
                               <asp:Button runat="server" CssClass="button" Text="ĐĂNG NHẬP" ID="btnDangNhap" OnClick="btnDangNhap_Click"/>
                           </div>
                        </div>
            </form>
                     </div>
        
</asp:Content>

