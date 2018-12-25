using DataConnection.App_Code.DataManager;
using DataConnection.App_Code.ORM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_Backend_QuanTri_QuanLyTaiKhoanNganHang_CapNhatTaiKhoan : System.Web.UI.Page
{
    public TaiKhoanNganHangManagement taiKhoanManagement = new TaiKhoanNganHangManagement();
  //  public NguoiDungManagement nguoiDungManagement = new NguoiDungManagement();
    //  public float hoaHongNguoiGioiThieu = 0;
    public TaiKhoanNganHang taiKhoan;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (HttpContext.Current.Request.QueryString["iDTaiKhoanNganHang"] != null)
        {
            string iDTaiKhoanNganHang = HttpContext.Current.Request.QueryString["iDTaiKhoanNganHang"].ToString();
            try
            {
                taiKhoan = taiKhoanManagement.getTaiKhoanNganHang("where ID=N'" + iDTaiKhoanNganHang + "'")[0];
                if (!this.IsPostBack)
                {
                    initializeDataInControl();
                }
            }
            catch (Exception ex)
            {
                taiKhoan = null;
            }
        }
    }

    private void initializeDataInControl()
    {

        txtTenChuThe.Text = taiKhoan.TenChuThe;
        txtSoTaiKhoan.Text = taiKhoan.SoTaiKhoan;
       TxtHanMucTrongNgay.Text= taiKhoan.HanMucTrongNgay.ToString() ;
    }
    protected void btnCapNhat_Click(object sender, EventArgs e)
    {
        taiKhoan.TenChuThe = txtTenChuThe.Text;
        taiKhoan.SoTaiKhoan = txtSoTaiKhoan.Text;
        taiKhoan.HanMucTrongNgay = float.Parse(TxtHanMucTrongNgay.Text);
        taiKhoanManagement.updateTaiKhoanNganHang(taiKhoan);
        Response.Redirect("/Views/Backend/QuanTri/QuanLyTaiKhoanNganHang/DanhSachTaiKhoanNganHang.aspx");
    }

    protected void btnQuayLai_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Views/Backend/QuanTri/QuanLytinTuc/DanhSachtinTuc.aspx");
    }
}