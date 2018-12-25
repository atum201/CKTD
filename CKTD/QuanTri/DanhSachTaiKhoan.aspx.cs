using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataConnection.App_Code.DataManager;

public partial class QuanTri_DanhSachTaiKhoan : System.Web.UI.Page
{
    public CKTDManagement cktd = new CKTDManagement();

    public int pageSize = 2;
    public int totalItem = 0;
    public int totalPage = 3;
    public int pageId = 1;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
}