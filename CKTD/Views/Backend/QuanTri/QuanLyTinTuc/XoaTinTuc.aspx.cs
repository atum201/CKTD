using DataConnection.App_Code.DataManager;
using DataConnection.App_Code.ORM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_Backend_QuanTri_QuanLyTinTuc_XoaTinTuc : System.Web.UI.Page
{
    public TinTucManagement tinTucManagement = new TinTucManagement();
  //  public NguoiDungManagement nguoiDungManagement = new NguoiDungManagement();
    //  public float hoaHongNguoiGioiThieu = 0;
    public TinTuc tinTuc;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (HttpContext.Current.Request.QueryString["iDTinTuc"] != null)
        {
            string iDTinTuc = HttpContext.Current.Request.QueryString["iDTinTuc"].ToString();
            try
            {
                tinTuc = tinTucManagement.getTinTuc("where ID=N'" + iDTinTuc + "'")[0];
                if (!this.IsPostBack)
                {
                    initializeDataInControl();
                }
            }
            catch (Exception ex)
            {
                tinTuc = null;
            }
        }
    }

    private void initializeDataInControl()
    {
        tinTucManagement.xoaTinTuc(tinTuc);
        Response.Redirect("/Views/Backend/QuanTri/QuanLytinTuc/DanhSachtinTuc.aspx");
    }
   
}