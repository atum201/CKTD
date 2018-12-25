using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConnection.App_Code.ORM.Model
{
    public class LoaiTien
    {
        public virtual int ID { get; set; }
        public virtual string TenLoaiTien { get; set; }
        public virtual float? GiaMua { get; set; }
        public virtual float? GiaBan { get; set; }
        public virtual string AutoLoad { get; set; }
        public virtual string TrangThai { get; set; }
        public virtual int? ThuTu { get; set; }
        public virtual float? HanMuc { get; set; }
        public virtual string ThongBaoHetHanMuc { get; set; }
        public virtual string LinkIcon { get; set; }
        public virtual string MaLoaiTien { get; set; }
        public virtual int? ThuTuHienThiBox { get; set; }
        public virtual float? PhuPhiMua { get; set; }
        public virtual float? PhuPhiBan { get; set; }
        
    }
}
