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
    public ThongTinHeThongManagement thongTinHeThongManagement = new ThongTinHeThongManagement();
    NguoiDungManagement nguoiDungManagement = new NguoiDungManagement();
    public LoaiTienManagement loaiTienManagement = new LoaiTienManagement();
    public IList<LoaiTien> listLoaiTienBox;
    //public ThongTinHeThong thongTinHeThong;
    public IList<NguoiDung> listNguoiDung;
    public string loainguoidung;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
}
