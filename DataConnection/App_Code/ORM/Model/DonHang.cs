using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConnection.App_Code.ORM.Model
{
    public class DonHang
    {
        public virtual int ID { get; set; }
        public virtual NguoiDung NguoiDung { get; set; }
        public virtual string MaGiaoDich { get; set; }
        public virtual LoaiTien LoaiTien { get; set; }
        public virtual float? SoLuong { get; set; }
        public virtual float? GiaTri { get; set; }
        public virtual string DiaChiViTien { get; set; }
        public virtual string SoDienThoai { get; set; }
        public virtual TaiKhoanNganHang TaiKhoanNganHang { get; set; }
        public virtual string LoaiDonHang { get; set; }
        public virtual string SoTaiKhoanNguoiBan { get; set; }
        public virtual string TenChuTaiKhoan { get; set; }
        public virtual string MaDiaChiViGiaoDich { get; set; }
        public virtual string TrangThai { get; set; }
        public virtual float? HoaHongNguoiGioiThieu { get; set; }
        public virtual DateTime? NgayTaoDonHang { get; set; }
        public virtual DateTime? NgayThanhToan { get; set; }
        public virtual string TrangThaiHoaHong { get; set; }
    }
}
