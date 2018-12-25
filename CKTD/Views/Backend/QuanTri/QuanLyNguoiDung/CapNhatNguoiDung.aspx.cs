using DataConnection.App_Code.DataManager;
using DataConnection.App_Code.ORM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_Backend_QuanTri_QuanLyNguoiDung_CapNhatNguoiDung : System.Web.UI.Page
{
    public DonHangManagement donHangManagement = new DonHangManagement();
    public NguoiDungManagement nguoiDungManagement = new NguoiDungManagement();
  //  public float hoaHongNguoiGioiThieu = 0;
    public NguoiDung nguoiDung;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (HttpContext.Current.Request.QueryString["iDNguoiDung"] != null)
        {
            string idNguoDung = HttpContext.Current.Request.QueryString["iDNguoiDung"].ToString();
            try
            {
                nguoiDung = nguoiDungManagement.getNguoiDung("where ID=N'" + idNguoDung + "'")[0];
                if (!this.IsPostBack)
                {
                    initializeDataInControl();
                }
            }
            catch (Exception ex)
            {
                nguoiDung = null;
            }
        }
    }

    private void initializeDataInControl()
    {
        txtHoTen.Text = nguoiDung.HoTen ;

        txtNguoiGioiThieu.Text = (nguoiDung.NguoiDungGioiThieu == null) ? "" : nguoiDung.NguoiDungGioiThieu.HoTen;

        txtTenDangNhap.Text = nguoiDung.TenDangNhap;
        txtNgaySinh.Text = nguoiDung.NgaySinh.ToString();
        txtSoCMT.Text = nguoiDung.SoCMT;
        txtMatKhau.Text = nguoiDung.MatKhau;
        txtSoDienThoai.Text = nguoiDung.SoDienThoai;
        txtEmail.Text = nguoiDung.Email;

        ddlLoaiNguoiDung.Items.Add(new ListItem("Quản trị", "QuanTri"));
        ddlLoaiNguoiDung.Items.Add(new ListItem("Người dùng", "NguoiDung"));
        ddlLoaiNguoiDung.SelectedValue = nguoiDung.LoaiNguoiDung;

        ddlTrangThai.Items.Add(new ListItem("Chưa kích hoạt", "ChuaKichHoat"));
        ddlTrangThai.Items.Add(new ListItem("Đã kích hoạt", "KichHoat"));
        ddlTrangThai.Items.Add(new ListItem("Không hoạt động", "KhongHoatDong"));

        if (nguoiDung.TrangThai.Contains("ChuaKichHoat"))
            ddlTrangThai.SelectedValue = "ChuaKichHoat";
        else
            ddlTrangThai.SelectedValue = nguoiDung.TrangThai;
    }
    protected void btnCapNhat_Click(object sender, EventArgs e)
    {
        //string trangThaiOld = donHang.TrangThai;
        //donHang.NgayThanhToan = DateTime.Now;
        //donHang.TrangThai = ddlTrangThai.SelectedValue;
        //donHangManagement.updateDonHang(donHang);

        nguoiDung.HoTen = txtHoTen.Text;
        nguoiDung.NgaySinh = DateTime.Parse(txtNgaySinh.Text);
        nguoiDung.SoCMT = txtSoCMT.Text;
        nguoiDung.MatKhau=txtMatKhau.Text;
        nguoiDung.SoDienThoai = txtSoDienThoai.Text;
        nguoiDung.Email = txtEmail.Text;
        nguoiDung.TrangThai = ddlTrangThai.SelectedValue;
        nguoiDung.LoaiNguoiDung = ddlLoaiNguoiDung.SelectedValue;
        nguoiDungManagement.updateNguoiDung(nguoiDung);
        Response.Redirect("/Views/Backend/QuanTri/QuanLyNguoiDung/DanhSachNguoiDung.aspx");
    }

    protected void btnQuayLai_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Views/Backend/QuanTri/QuanLyNguoiDung/DanhSachNguoiDung.aspx");
    }
}