using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataConnection.App_Code.DataManager;
using DataConnection.App_Code.ORM.Model;

public partial class QuanTri_DanhSachTaiKhoan : System.Web.UI.Page
{
    public CKTDManagement cktd = new CKTDManagement();
    public CKTDCommon ckcm = new CKTDCommon();
    public int pageSize = 10;
    public int totalItem = 0;
    public int totalPage = 0;
    public int pageId = 1;
    protected void Page_Load(object sender, EventArgs e)
    {
        IList<CKTD_TaiKhoan> listTaiKhoan = cktd.getCKTD_TaiKhoan(string.Empty, pageId, pageSize);
        this.totalItem = cktd.countCKTD_TaiKhoan(string.Empty);
        showDanhSach.Text = ckcm.ShowTaiKhoan(listTaiKhoan, (pageId - 1) * pageSize);
    }
}