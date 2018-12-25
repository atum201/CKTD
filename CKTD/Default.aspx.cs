using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["MaGiaoDich"] != null)
        {
            Response.Redirect("/Views/Frontend/ChiTietDonHang.aspx?maGiaoDich=" + Request.Cookies["MaGiaoDich"].Value);
        }
        //Response.Redirect("/Views/Frontend/MuaBanCoin.aspx");
        Response.Redirect("/QuanTri/DanhSachTaiKhoan.aspx");
    }
}