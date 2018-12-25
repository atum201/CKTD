using DataConnection.App_Code.DataManager;
using DataConnection.App_Code.ORM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_Backend_QuanTri_QuanLyLoaiTien_XoaLoaiTien : System.Web.UI.Page
{
    public DonHangManagement donHangManagement = new DonHangManagement();
    public NguoiDungManagement nguoiDungManagement = new NguoiDungManagement();
    public LoaiTienManagement loaiTienManagement = new LoaiTienManagement();

    public LoaiTien loaiTien;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (HttpContext.Current.Request.QueryString["iDLoaiTien"] != null)
        {
            string iDLoaiTien = HttpContext.Current.Request.QueryString["iDLoaiTien"].ToString();
            try
            {
                loaiTien = loaiTienManagement.getLoaiTien("where ID=N'" + iDLoaiTien + "'")[0];
                if (!this.IsPostBack)
                {
                    initializeDataInControl();
                }
            }
            catch (Exception ex)
            {
                loaiTien = null;
            }
        }
    }

    private void initializeDataInControl()
    {
        loaiTien.TrangThai = "DaXoa";
        loaiTienManagement.updateLoaiTien(loaiTien);
        Response.Redirect("/Views/Backend/QuanTri/QuanLyLoaiTien/DanhSachLoaiTien.aspx");
    }
   
   
}