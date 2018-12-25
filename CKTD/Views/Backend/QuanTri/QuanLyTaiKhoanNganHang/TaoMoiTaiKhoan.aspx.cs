using DataConnection.App_Code.DataManager;
using DataConnection.App_Code.ORM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_Backend_QuanTri_QuanLyTaiKhoanNganHang_TaoMoiTaiKhoan : System.Web.UI.Page
{
    public DonHangManagement donHangManagement = new DonHangManagement();
    public NguoiDungManagement nguoiDungManagement = new NguoiDungManagement();
    public TaiKhoanNganHangManagement taiKhoanManagement = new TaiKhoanNganHangManagement();

    public TaiKhoanNganHang taiKhoan;
    protected void Page_Load(object sender, EventArgs e)
    {
       // if (HttpContext.Current.Request.QueryString["iDNguoiDung"] != null)
       // {
          //  string idNguoDung = HttpContext.Current.Request.QueryString["iDNguoiDung"].ToString();
            try
            {
              //  nguoiDung = nguoiDungManagement.getNguoiDung("where ID=N'" + idNguoDung + "'")[0];
                if (!this.IsPostBack)
                {
                }
            }
            catch (Exception ex)
            {
               // nguoiDung = null;
            }
       // }
    }


    protected void btnLuu_Click(object sender, EventArgs e)
    {
        taiKhoan = new TaiKhoanNganHang();
        taiKhoan.TenChuThe = txtTenChuThe.Text;
        taiKhoan.SoTaiKhoan = txtSoTaiKhoan.Text;
        taiKhoan.HanMucTrongNgay = float.Parse( TxtHanMucTrongNgay.Text);
        taiKhoanManagement.themTaiKhoanNganHang(taiKhoan);
        Response.Redirect("/Views/Backend/QuanTri/QuanLyTaiKhoanNganHang/DanhSachTaiKhoanNganHang.aspx");
    }

    protected void btnQuayLai_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Views/Backend/QuanTri/QuanLyTaiKhoanNganHang/DanhSachTaiKhoanNganHang.aspx");
    }
}