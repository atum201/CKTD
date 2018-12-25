using DataConnection.App_Code.DataManager;
using DataConnection.App_Code.ORM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_Frontend_DangKy : System.Web.UI.Page
{
    NguoiDungManagement nguoiDungManagement = new NguoiDungManagement();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnDangKy_Click(object sender, EventArgs e)
    {
        NguoiDung nguoiDung = new NguoiDung();
        nguoiDung.TenDangNhap = txtTenDangNhap.Text;
        nguoiDung.MatKhau = txtMatKhau.Text;
        nguoiDung.Email = txtEmail.Text;
        nguoiDung.SoDienThoai = txtSoDienThoai.Text;
        string maKichHoat=CommonUtil.GetStringSha256Hash(nguoiDung.TenDangNhap);
        nguoiDung.TrangThai = "ChuaKichHoat_"+maKichHoat;
        nguoiDung.LoaiNguoiDung = "NguoiDung";
        if (Request.Cookies["IDNguoiDungGioiThieu"] != null)
        {
            nguoiDung.NguoiDungGioiThieu = nguoiDungManagement.getNguoiDungById(int.Parse(Request.Cookies["IDNguoiDungGioiThieu"].ToString()));
        }


        nguoiDungManagement.themNguoiDung(nguoiDung);
        SendEmail.Send(nguoiDung.Email, "Kích hoạt tài khoản", "Vui lòng click vào đây để kích hoạt tài khoản: http://123.31.40.147/Views/Frontend/KichHoatTaiKhoan.aspx?maKichHoat="+maKichHoat);


    }
}