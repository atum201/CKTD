using DataConnection.App_Code.DataManager;
using DataConnection.App_Code.ORM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OneColumn : System.Web.UI.MasterPage
{
    public CKTDManagement cktd = new CKTDManagement();
    public IList<CKTD_TaiKhoan> listNguoiDung;
    public int loainguoidung;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["TenDangNhap"] != null)
        {
            listNguoiDung = cktd.getCKTD_TaiKhoan("WHERE TaiKhoan=N'" + Session["TenDangNhap"] + "'");
            if (listNguoiDung.Count > 0)
            {
                loainguoidung = listNguoiDung[0].LoaiNguoiDung.Value;

            }
            else
            {
                loainguoidung = (int)CKTDLoaiNguoiDung.Khac;
            }
        }
    }
}
