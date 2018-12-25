using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConnection.App_Code.ORM.Model
{
    public class TaiKhoanNganHang
    {
        public virtual int ID { get; set; }
        public virtual string TenChuThe { get; set; }
        public virtual string SoTaiKhoan { get; set; }
        public virtual float? HanMucTrongNgay { get; set; }
        public virtual string TrangThai { get; set; }

    }
}
