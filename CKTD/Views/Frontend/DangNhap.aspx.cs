using DataConnection.App_Code.DataManager;
using DataConnection.App_Code.ORM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_Frontend_DangNhap : System.Web.UI.Page
{
    NguoiDungManagement nguoiDungManagement = new NguoiDungManagement();
    public IList<NguoiDung> listNguoiDung;
    public NguoiDung nguoiDung;
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btnDangNhap_Click(object sender, EventArgs e)
    {
        
        if (new NguoiDungManagement().xacThucNguoiDung(txtTenDangNhap.Text, txtPassword.Text))
        {

            //FormsAuthentication.SetAuthCookie(txtTenDangNhap.Text, true);
            Session["TenDangNhap"] = txtTenDangNhap.Text;
            
            listNguoiDung = nguoiDungManagement.getNguoiDung("WHERE TenDangNhap=N'" + txtTenDangNhap.Text + "'");
            if (listNguoiDung.Count > 0)
            {
                string loainguoidung = listNguoiDung[0].LoaiNguoiDung;
                if(loainguoidung=="QuanTri")
                    Response.Redirect("/Views/Backend/QuanTri/QuanLyDonHang/DanhSachDonHang.aspx");
                else
                    Response.Redirect("/");
            }
            else
            { 
                Response.Redirect("/");
            }

        }
        else
        {
            HttpContext.Current.Response.Write("<script type=\"text/javascript\">alert(\"Nhập sai thông tin đăng nhập.\");</script>");
        }


    }
}