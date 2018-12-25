using DataConnection.App_Code.DataManager;
using DataConnection.App_Code.ORM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_Backend_QuanTri_QuanLyNguoiDung_DanhSachNguoiDung : System.Web.UI.Page
{
    public NguoiDungManagement nguoiDungManagement = new NguoiDungManagement();


    public IList<NguoiDung> listNguoiDung;
    public NguoiDung nguoiDung;

    public int pageSize = 2;
    public int totalItem = 0;
    public int totalPage = 3;
    public int pageId = 1;
    protected void Page_Load(object sender, EventArgs e)
    {
        listNguoiDung = nguoiDungManagement.getNguoiDung("", " ID asc", pageId, pageSize);
        totalItem = nguoiDungManagement.countNguoiDung("");
        ltPage.Text = CommonUtil.pageNavigator_TrangTrong("loadDSBanGhi", pageId, totalPage, pageSize, totalItem);
    }
    protected void btnXoa_Click(object sender, EventArgs e)
    {
        //string trangThaiOld = donHang.TrangThai;
        //donHang.NgayThanhToan = DateTime.Now;
        //donHang.TrangThai = ddlTrangThai.SelectedValue;
        //donHangManagement.updateDonHang(donHang);

        nguoiDung.TrangThai = "KhongHoatDong";
        nguoiDungManagement.updateNguoiDung(nguoiDung);
        Response.Redirect("/Views/Backend/QuanTri/QuanLyNguoiDung/DanhSachNguoiDung.aspx");
    }

}