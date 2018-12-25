using DataConnection.App_Code.DataManager;
using DataConnection.App_Code.ORM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_Frontend_KichHoatTaiKhoan : System.Web.UI.Page
{
    NguoiDungManagement nguoiDungManagement = new NguoiDungManagement();
    public bool flag = false;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (HttpContext.Current.Request.QueryString["maKichHoat"] != null)
        {
            string maKichHoat = HttpContext.Current.Request.QueryString["maKichHoat"].ToString();
            IList<NguoiDung> listNguoiDung = nguoiDungManagement.getNguoiDung("where TrangThai like N'%"+maKichHoat+"'");
            if (listNguoiDung != null && listNguoiDung.Count > 0)
            {
                listNguoiDung[0].TrangThai = "KichHoat";
                nguoiDungManagement.updateNguoiDung(listNguoiDung[0]);
                Session["TenDangNhap"] = listNguoiDung[0].TenDangNhap;
                flag = true;
            }
        }
    }
}