using DataConnection.App_Code.DataManager;
using DataConnection.App_Code.ORM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_Backend_QuanTri_QuanLyDonHang_CapNhatDonHang : System.Web.UI.Page
{
    public DonHangManagement donHangManagement = new DonHangManagement();
    public NguoiDungManagement nguoiDungManagement = new NguoiDungManagement();
    public float hoaHongNguoiGioiThieu = 0;
    public DonHang donHang;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (HttpContext.Current.Request.QueryString["maGiaoDich"] != null)
        {
            string maGiaoDich = HttpContext.Current.Request.QueryString["maGiaoDich"].ToString();
            try
            {
                donHang = donHangManagement.getDonHang("where maGiaoDich=N'" + maGiaoDich + "'")[0];
                if (!this.IsPostBack)
                {
                    initializeDataInControl();
                }
            }
            catch (Exception ex)
            {
                donHang = null;
            }
        }
    }

    private void initializeDataInControl()
    {
        txtMaGiaoDich.Text = donHang.MaGiaoDich??"";
        txtLoaiGiaoDich.Text = (donHang.LoaiDonHang=="KhachMua")?"Khách mua coin":"Khách bán coin";
        txtLoaiTien.Text = donHang.LoaiTien.TenLoaiTien;
        txtSoLuong.Text = donHang.SoLuong.ToString();
        txtGiaTri.Text = donHang.GiaTri.Value.ToString("0.#");
        if (donHang.LoaiDonHang == "KhachMua")
        {
            ddlTrangThai.Items.Add(new ListItem("Chưa thanh toán","ChuaThanhToan"));
            ddlTrangThai.Items.Add(new ListItem("Đã thanh toán","DaThanhToan"));
            ddlTrangThai.Items.Add(new ListItem("Đã chuyển coin","DaChuyenCoin"));
            ddlTrangThai.SelectedValue = donHang.TrangThai;
            if (donHang.TrangThai == "DaChuyenCoin")
            {
                ddlTrangThai.Enabled = false;
                btnCapNhat.Enabled = false;
            }

            txtDiaChiViTien.Text = donHang.DiaChiViTien;
            txtSoDienThoai.Text = donHang.SoDienThoai;
        }
        if (donHang.LoaiDonHang == "KhachBan") 
        {
            ddlTrangThai.Items.Add(new ListItem("Chưa chuyển coin", "ChuaChuyenCoin"));
            ddlTrangThai.Items.Add(new ListItem("Đã chuyển coin","DaChuyenCoin" ));
            ddlTrangThai.Items.Add(new ListItem("Đã thanh toán","DaThanhToan" ));
            ddlTrangThai.SelectedValue = donHang.TrangThai;
            if (donHang.TrangThai == "DaThanhToan")
            {
                ddlTrangThai.Enabled = false;
                btnCapNhat.Enabled = false;
            }

            txtTaiKhoanNganHang.Text = (donHang.TaiKhoanNganHang!=null)?donHang.TaiKhoanNganHang.SoTaiKhoan:"";
            txtSoTaiKhoanNguoiBan.Text = donHang.SoTaiKhoanNguoiBan??"";
            txtTenChuTaiKhoan.Text = donHang.TenChuTaiKhoan??"";
            txtMaDiaChiViGiaoDich.Text = donHang.MaDiaChiViGiaoDich??"";
        }

        txtHoaHongNguoiGioiThieu.Text =(donHang.HoaHongNguoiGioiThieu!=null)? donHang.HoaHongNguoiGioiThieu.ToString():"";
        txtNgayTaoDonHang.Text = (donHang.NgayTaoDonHang!=null)?donHang.NgayTaoDonHang.Value.ToString("dd-MM-yyyy HH:mm:ss"):"";
        txtNgayThanhToan.Text = (donHang.NgayThanhToan!=null)?donHang.NgayThanhToan.Value.ToString("dd-MM-yyyy HH:mm:ss"):"";

        if (Session["TenDangNhap"] != null)
        {
            NguoiDung currentUser;
            try
            {
                currentUser = nguoiDungManagement.getNguoiDung(" where TrangThai=N'HoatDong' and TenDangNhap=N'" + Session["TenDangNhap"].ToString() + "'")[0];
            }
            catch (Exception ex)
            {
                currentUser = null;
            }
            if (currentUser != null && currentUser.NguoiDungGioiThieu != null)
            {
                if (currentUser.KichHoatHoaHong == "KichHoat")
                {
                    ThongTinHeThong thongTinHeThong = new ThongTinHeThongManagement().getThongTinHeThong()[0];
                    hoaHongNguoiGioiThieu = donHang.GiaTri.Value * thongTinHeThong.TiLeChiaHoaHong.Value / 100;
                }
            }
        }

    }
    protected void btnCapNhat_Click(object sender, EventArgs e)
    {
        string trangThaiOld = donHang.TrangThai;
        donHang.NgayThanhToan = DateTime.Now;
        donHang.TrangThai = ddlTrangThai.SelectedValue;
        donHangManagement.updateDonHang(donHang);
        if (Session["TenDangNhap"] != null)
        {
            NguoiDung currentUser;
            try
            {
                currentUser = nguoiDungManagement.getNguoiDung(" where TrangThai=N'HoatDong' and TenDangNhap=N'" + Session["TenDangNhap"].ToString() + "'")[0];
            }
            catch (Exception ex)
            {
                currentUser = null;
            }
            if (currentUser != null && currentUser.NguoiDungGioiThieu != null)
            {
                if (currentUser.KichHoatHoaHong == "KichHoat")
                {
                    if (
                        (donHang.LoaiDonHang == "KhachMua" && ddlTrangThai.SelectedValue == "DaChuyenCoin" && trangThaiOld != "DaChuyenCoin")||
                        (donHang.LoaiDonHang == "KhachBan" && ddlTrangThai.SelectedValue == "DaThanhToan" && trangThaiOld != "DaThanhToan")
                       )
                    {
                            ThongTinHeThong thongTinHeThong = new ThongTinHeThongManagement().getThongTinHeThong()[0];
                            donHang.HoaHongNguoiGioiThieu = donHang.GiaTri * thongTinHeThong.TiLeChiaHoaHong / 100;
                            donHang.TrangThaiHoaHong = "DaKichHoat";
                            
                            donHangManagement.updateDonHang(donHang);
                        
                    }
                }
                else
                {
                    if (
                        (donHang.LoaiDonHang == "KhachMua" && ddlTrangThai.SelectedValue == "DaChuyenCoin" && trangThaiOld != "DaChuyenCoin")||
                        (donHang.LoaiDonHang == "KhachBan" && ddlTrangThai.SelectedValue == "DaThanhToan" && trangThaiOld != "DaThanhToan")
                       )
                    {
                        
                        IList<DonHang> listDonHangDaGiaoDich = donHangManagement.getDonHang(" where IDNguoiDung=" + currentUser.ID + " and (TrangThai='DaChuyenCoin' or TrangThai='DaThanhToan')");
                        if (listDonHangDaGiaoDich != null)
                        {
                            float tongSoTienDaGiaoDich = 0;
                            for (int i = 0; i < listDonHangDaGiaoDich.Count; i++)
                            {
                                tongSoTienDaGiaoDich += listDonHangDaGiaoDich[i].GiaTri.Value;
                            }
                            ThongTinHeThong thongTinHeThong = new ThongTinHeThongManagement().getThongTinHeThong()[0];
                            if (thongTinHeThong.GiaTriKichHoatHoaHong <= tongSoTienDaGiaoDich)
                            {
                                currentUser.KichHoatHoaHong = "KichHoat";
                                nguoiDungManagement.updateNguoiDung(currentUser);
                            }
                        }
                    }
                }
                
            }
        }
        Response.Redirect("/Views/Backend/QuanTri/QuanLyDonHang/DanhSachDonHang.aspx");
    }

    protected void btnQuayLai_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Views/Backend/QuanTri/QuanLyDonHang/DanhSachDonHang.aspx");
    }
}