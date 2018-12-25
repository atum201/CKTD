using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataConnection.App_Code.DataManager;
using DataConnection.App_Code.ORM.Model;

public partial class QuanTri_loadDanhSach : System.Web.UI.Page
{
    public CKTDManagement cktd = new CKTDManagement();
    public CKTDCommon ckcm = new CKTDCommon();
    public int pageSize = 2;
    public int totalItem = 0;
    public int totalPage = 3;
    public int pageId = 1;
    public int loai = 0;
    public string DanhSachContent = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["pageId"] != null)
        {
            int.TryParse(Request.QueryString["pageId"].ToString(), out this.pageId);
        }
        if (Request.QueryString["pageSize"] != null)
        {
            int.TryParse(Request.QueryString["pageSize"].ToString(), out this.pageSize);
        }
        if (Request.QueryString["totalItem"] != null)
        {
            int.TryParse(Request.QueryString["totalItem"].ToString(), out this.totalItem);
        }
        if (Request.QueryString["totalPage"] != null)
        {
            int.TryParse(Request.QueryString["totalPage"].ToString(), out this.totalPage);
        }
        if (Request.QueryString["loai"] != null)
        {
            int.TryParse(Request.QueryString["loai"].ToString(), out this.loai);
        }
        switch (loai){
            case (int)LoaiDanhSach.TaiKhoan:
                IList<CKTD_TaiKhoan> listTaiKhoan = cktd.getCKTD_TaiKhoan(string.Empty, pageId, pageSize);
                this.totalItem = cktd.countCKTD_TaiKhoan(string.Empty);
                this.DanhSachContent = ckcm.ShowTaiKhoan(listTaiKhoan, (pageId - 1) * pageSize);
                break;
            case (int)LoaiDanhSach.DichVuCong:
                IList<CKTD_DichVuCong> listDichVuCong = cktd.getCKTD_DichVuCong(string.Empty, pageId, pageSize);
                this.totalItem = cktd.countCKTD_DichVuCong(string.Empty);
                this.DanhSachContent = ckcm.ShowDichVuCong(listDichVuCong, (pageId - 1) * pageSize);
                break;
            case (int)LoaiDanhSach.VanBan:
                IList<CKTD_VanBan> listVanBan = cktd.getCKTD_VanBan(string.Empty, pageId, pageSize);
                this.totalItem = cktd.countCKTD_VanBan(string.Empty);
                this.DanhSachContent = ckcm.ShowVanBan(listVanBan, (pageId - 1) * pageSize);
                break;
            case (int)LoaiDanhSach.DonVi:break;
                IList<CKTD_DonVi> listDonVi = cktd.getCKTD_DonVi(string.Empty, pageId, pageSize);
                this.totalItem = cktd.countCKTD_DonVi(string.Empty);
                this.DanhSachContent = ckcm.ShowDonVi(listDonVi, (pageId - 1) * pageSize);
            default:
                break;
        }
    }
}