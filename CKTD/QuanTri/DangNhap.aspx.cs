using DataConnection.App_Code.DataManager;
using DataConnection.App_Code.ORM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class QuanTri_DangNhap : System.Web.UI.Page
{
    public CKTDManagement cktd = new CKTDManagement();
    public CKTDCommon ckcm = new CKTDCommon();
    public IList<CKTD_TaiKhoan> listNguoiDung;
    //public NguoiDungManagement nd = new NguoiDungManagement();
    public NguoiDung nguoiDung;
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btnDangNhap_Click(object sender, EventArgs e)
    {
        if (cktd.xacThucTaiKhoan(txtTenDangNhap.Text, txtPassword.Text))
        {
            Session["TenDangNhap"] = txtTenDangNhap.Text;
            Response.Redirect("/QuanTri/DanhSachTaiKhoan.aspx");
        }
        else
        {
            HttpContext.Current.Response.Write("<script type=\"text/javascript\">alert(\"Nhập sai thông tin đăng nhập.\");</script>");
        }


    }
}