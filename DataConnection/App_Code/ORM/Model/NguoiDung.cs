using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConnection.App_Code.ORM.Model
{
    public class NguoiDung
    {
        public virtual int ID { get; set; }
        public virtual string TenDangNhap { get; set; }
        public virtual string MatKhau { get; set; }
        public virtual string TrangThai { get; set; }
        public virtual string LoaiNguoiDung { get; set; }
        public virtual string HoTen { get; set; }
        public virtual DateTime? NgaySinh { get; set; }
        public virtual string SoCMT { get; set; }
        public virtual string Email { get; set; }
        public virtual string SoDienThoai { get; set; }
        public virtual NguoiDung NguoiDungGioiThieu { get; set; }
        public virtual string KichHoatHoaHong { get; set; }
    }
}
