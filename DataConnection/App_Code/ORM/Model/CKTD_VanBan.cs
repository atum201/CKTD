using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConnection.App_Code.ORM.Model
{
    public class CKTD_VanBan
    {
        public virtual int ID { get; set; }
        public virtual CKTD_DonVi DonVi { get; set; }
        public virtual string MoTa { get; set; }
        public virtual int TrangThai { get; set; }
        public virtual int TongSoVanBanTraoDoi { get; set; }
        public virtual int KieuHienThi { get; set; }
        public virtual DateTime? TuNgay { get; set; }
        public virtual DateTime? DenNgay { get; set; }
        public virtual DateTime? ThoiGianCapNhat { get; set; }
    }
}
