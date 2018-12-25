using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConnection.App_Code.ORM.Model
{
    public class CKTD_DichVuCong
    {
        public virtual int ID { get; set; }
        public virtual CKTD_DonVi DonVi { get; set; }
        public virtual string MoTa { get; set; }
        public virtual int TrangThai { get; set; }
        public virtual int TongSoHoSoTiepNhan { get; set; }
        public virtual int TongSoHoSoDaXyLy { get; set; }
        public virtual int TongSoHoSoDungHan { get; set; }
        public virtual float? TyLeDungHan { get; set; }
        public virtual int CongThucTinh { get; set; }
        public virtual int LoaiDichVuCong { get; set; }
        public virtual DateTime? TuNgay { get; set; }
        public virtual DateTime? DenNgay { get; set; }
        public virtual DateTime? ThoiGianCapNhat { get; set; }
    }
}
