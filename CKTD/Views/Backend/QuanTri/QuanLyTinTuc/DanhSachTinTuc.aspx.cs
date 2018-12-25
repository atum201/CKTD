using DataConnection.App_Code.DataManager;
using DataConnection.App_Code.ORM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Views_Backend_QuanTri_QuanLyTinTuc_DanhSachTinTuc : System.Web.UI.Page
{
    public TinTucManagement tinTucManagement = new TinTucManagement();


    public IList<TinTuc> listTinTuc;


    public int pageSize = 2;
    public int totalItem = 0;
    public int totalPage = 3;
    public int pageId = 1;
    protected void Page_Load(object sender, EventArgs e)
    {
        listTinTuc = tinTucManagement.getTinTuc("", " ID asc", pageId, pageSize);
        totalItem = tinTucManagement.countTinTuc("");
        ltPage.Text = CommonUtil.pageNavigator_TrangTrong("loadDSBanGhi", pageId, totalPage, pageSize, totalItem);
    }
}