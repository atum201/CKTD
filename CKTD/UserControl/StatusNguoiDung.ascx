<%@ Control Language="C#" AutoEventWireup="true" CodeFile="StatusNguoiDung.ascx.cs" Inherits="UserControl_StatusNguoiDung" %>
<%if (Session["TenDangNhap"] == null)
{ 
        %>
<span class="userAction">
<a href="/QuanTri/DangNhap.aspx" class="login">ĐĂNG NHẬP</a>
<a href="/QuanTri/DangKy.aspx" class="register">ĐĂNG KÝ</a>
</span>
<%}else{ %>

<div class="loggedIn">
	<span class="name"><img src="themes/page/images/icon-user-1.png" alt=""><%=Session["TenDangNhap"].ToString() %></span>
	<ul style="display: none;">
							
		<li><a href="/">Xác minh</a></li>
							
		<li><a href="/Views/Backend/NguoiDung/DanhSachDonHangNguoiDung.aspx">Đơn hàng</a></li>
		<li><a href="/">Đổi mật khẩu</a></li>
		<li><a href="/Views/Frontend/DangXuat.aspx" onclick="return confirm('Bạn chắc chắn ?');">Đăng xuất</a></li>
	</ul>
</div>
<%} %>