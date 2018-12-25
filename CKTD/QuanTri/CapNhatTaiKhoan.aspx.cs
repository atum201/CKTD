using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataConnection.App_Code.DataManager;
using DataConnection.App_Code.ORM.Model;

public partial class QuanTri_CapNhatTaiKhoan : System.Web.UI.Page
{
    public CKTDManagement cktd = new CKTDManagement();
    public CKTD_TaiKhoan nguoidung;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (HttpContext.Current.Request.QueryString["TaiKhoan"] != null)
        {
            string taiKhoan = HttpContext.Current.Request.QueryString["TaiKhoan"].ToString();
            try
            {
                nguoidung = cktd.getCKTD_TaiKhoan("where TaiKhoan=N'" + taiKhoan + "'")[0];
                if (!this.IsPostBack)
                {
                    initializeDataInControl();
                }
            }
            catch (Exception ex)
            {
                nguoidung = null;
            }
        }
    }

    private void initializeDataInControl()
    {

    }

    protected void btnCapNhat_Click(object sender, EventArgs e)
    {

    }
    protected void btnQuayLai_Click(object sender, EventArgs e)
    {
        Response.Redirect("/QuanTri/DanhSachTaiKhoan.aspx");
    }
}