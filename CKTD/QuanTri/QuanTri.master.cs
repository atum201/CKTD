using DataConnection.App_Code.DataManager;
using DataConnection.App_Code.ORM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class QuanTri_QuanTri : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["TenDangNhap"] == null)
            Response.Redirect("/QuanTri/DangNhap.aspx");
    }
}
