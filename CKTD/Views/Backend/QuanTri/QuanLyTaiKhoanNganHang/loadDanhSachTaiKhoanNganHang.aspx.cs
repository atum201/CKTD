using DataConnection.App_Code.DataManager;
using DataConnection.App_Code.ORM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_Backend_QuanTri_QuanLyTaiKhoanNganHang_loadDanhSachTaiKhoanNganHang : System.Web.UI.Page
{
    public TaiKhoanNganHangManagement taiKhoanNganHangManagement = new TaiKhoanNganHangManagement();


    public IList<TaiKhoanNganHang> listTaiKhoanNganHang;
    public int pageSize = 2;
    public int totalItem = 0;
    public int totalPage = 3;
    public int pageId = 1;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["pageId"] != null)
        {
            pageId = int.Parse(Request.QueryString["pageId"].ToString());
        }
        if (Request.QueryString["pageSize"] != null)
        {
            pageSize = int.Parse(Request.QueryString["pageSize"].ToString());
        }
        if (Request.QueryString["totalItem"] != null)
        {
            totalItem = int.Parse(Request.QueryString["totalItem"].ToString());
        }
        if (Request.QueryString["totalPage"] != null)
        {
            totalPage = int.Parse(Request.QueryString["totalPage"].ToString());
        }
        listTaiKhoanNganHang = taiKhoanNganHangManagement.getTaiKhoanNganHang("", " ID asc", pageId, pageSize);
        totalItem = taiKhoanNganHangManagement.countTaiKhoanNganHang("");
        ltPage.Text = CommonUtil.pageNavigator_TrangTrong("loadDSBanGhi", pageId, totalPage, pageSize, totalItem);
    }
}