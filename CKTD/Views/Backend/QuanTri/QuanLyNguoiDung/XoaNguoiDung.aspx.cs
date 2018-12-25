using DataConnection.App_Code.DataManager;
using DataConnection.App_Code.ORM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_Backend_QuanTri_QuanLyNguoiDung_XoaNguoiDung : System.Web.UI.Page
{
    public DonHangManagement donHangManagement = new DonHangManagement();
    public NguoiDungManagement nguoiDungManagement = new NguoiDungManagement();
  //  public float hoaHongNguoiGioiThieu = 0;
    public NguoiDung nguoiDung;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (HttpContext.Current.Request.QueryString["iDNguoiDung"] != null)
        {
            string idNguoDung = HttpContext.Current.Request.QueryString["iDNguoiDung"].ToString();
            try
            {
                nguoiDung = nguoiDungManagement.getNguoiDung("where ID=N'" + idNguoDung + "'")[0];
                if (!this.IsPostBack)
                {
                    btnXoa();
                }
            }
            catch (Exception ex)
            {
                nguoiDung = null;
            }
        }
    }

    protected void btnXoa()
    {
        //string trangThaiOld = donHang.TrangThai;
        //donHang.NgayThanhToan = DateTime.Now;
        //donHang.TrangThai = ddlTrangThai.SelectedValue;
        //donHangManagement.updateDonHang(donHang);

        nguoiDung.TrangThai = "KhongHoatDong";
        nguoiDungManagement.updateNguoiDung(nguoiDung);
        Response.Redirect("/Views/Backend/QuanTri/QuanLyNguoiDung/DanhSachNguoiDung.aspx");
    }
}