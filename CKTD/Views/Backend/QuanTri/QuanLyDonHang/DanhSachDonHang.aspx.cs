using DataConnection.App_Code.DataManager;
using DataConnection.App_Code.ORM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_Backend_QuanTri_QuanLyDonHang_DanhSachDonHang : System.Web.UI.Page
{
    public LoaiTienManagement loaiTienManagement = new LoaiTienManagement();
    public NguoiDungManagement nguoiDungManagement = new NguoiDungManagement();
    public DonHangManagement donHangManagement = new DonHangManagement();
    public IList<DonHang> listDonHang;
    public int pageSize = 2;
    public int totalItem = 0;
    public int totalPage = 3;
    public int pageId = 1;
    protected void Page_Load(object sender, EventArgs e)
    {
        listDonHang = donHangManagement.getDonHang(""," ID asc",pageId,pageSize);
        totalItem = donHangManagement.countDonHang("");
        ltPage.Text = CommonUtil.pageNavigator_TrangTrong("loadDSBanGhi", pageId, totalPage, pageSize, totalItem);
    }
}