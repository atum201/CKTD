using DataConnection.App_Code.DataManager;
using DataConnection.App_Code.ORM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_Backend_NguoiDung_DanhSachDonHangNguoiDung : System.Web.UI.Page
{
    public LoaiTienManagement loaiTienManagement = new LoaiTienManagement();
    public NguoiDungManagement nguoiDungManagement = new NguoiDungManagement();
    public DonHangManagement donHangManagement = new DonHangManagement();
   // NguoiDungManagement nguoiDungManagement = new NguoiDungManagement();
    public IList<NguoiDung> listNguoiDung;
    public IList<DonHang> listDonHang;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["TenDangNhap"] != null)
        {
            listNguoiDung = nguoiDungManagement.getNguoiDung("WHERE TenDangNhap=N'" + Session["TenDangNhap"] + "'");
            if (listNguoiDung.Count > 0)
            {
                listDonHang = donHangManagement.getDonHang("WHERE IDNguoiDung=N'" + listNguoiDung[0].ID + "'");  

            }
            
        }
       

    }
}