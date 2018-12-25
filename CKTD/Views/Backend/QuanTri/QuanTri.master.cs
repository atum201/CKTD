using DataConnection.App_Code.DataManager;
using DataConnection.App_Code.ORM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_Backend_QuanTri_QuanTri : System.Web.UI.MasterPage
{
    public ThongTinHeThongManagement thongTinHeThongManagement = new ThongTinHeThongManagement();
    NguoiDungManagement nguoiDungManagement = new NguoiDungManagement();
    public LoaiTienManagement loaiTienManagement = new LoaiTienManagement();
    public IList<LoaiTien> listLoaiTienBox;
    public ThongTinHeThong thongTinHeThong;
    public IList<NguoiDung> listNguoiDung;
    public string loainguoidung;
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Session["TenDangNhap"] == null)
        //{
        //    Response.Redirect("/");
        //}
        thongTinHeThong = thongTinHeThongManagement.getThongTinHeThong()[0];
        listLoaiTienBox = loaiTienManagement.getLoaiTien(" where TrangThai=N'KichHoat' and ThuTuHienThiBox>0");
        //hòa sửa 24/02 thêm vào ktr hiển thị menu quản trị
        if (Session["TenDangNhap"] != null)
        {
            listNguoiDung = nguoiDungManagement.getNguoiDung("WHERE TenDangNhap=N'" + Session["TenDangNhap"] + "'");
            if (listNguoiDung.Count > 0)
            {
                loainguoidung = listNguoiDung[0].LoaiNguoiDung;

            }
            else
            {
                loainguoidung = "";
            }
        }
    }
}
