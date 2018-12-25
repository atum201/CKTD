using DataConnection.App_Code.DataManager;
using DataConnection.App_Code.ORM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_Frontend_TraCuu : System.Web.UI.Page
{
    public DonHangManagement donHangManagement = new DonHangManagement();
    public DonHang donHang;
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btnTraCuu_Click(object sender, EventArgs e)
    {
        IList<DonHang> listDonHang = donHangManagement.getDonHang(" where maGiaoDich=N'"+txtMaTraCuu.Text.Trim()+"'");
        if (listDonHang != null && listDonHang.Count > 0)
        {
            Response.Redirect("/Views/Frontend/ChiTietDonHang.aspx?maGiaoDich=" + txtMaTraCuu.Text.Trim());
        }
        else
        {
            lblMessage.Text = "Không tồn tại đơn hàng với mã trên.";
        }
    }
}