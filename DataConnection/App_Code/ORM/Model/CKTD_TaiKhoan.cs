using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConnection.App_Code.ORM.Model
{
    public class CKTD_TaiKhoan
    {
        public virtual int ID { get; set; }
        public virtual string TaiKhoan { get; set; }
        public virtual string MatKhau { get; set; }
        public virtual int? TrangThai { get; set; }
        public virtual string Ten { get; set; }
        public virtual int? LoaiNguoiDung { get; set; }
        public virtual int? Role { get; set; }
    }
}
