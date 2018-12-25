using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConnection.App_Code.ORM.Model
{
    public class ThongTinHeThong
    {
        public virtual int ID { get; set; }
        public virtual string LinkLogo { get; set; }
        public virtual string LinkBanner { get; set; }
        public virtual string TimeZoneSystem { get; set; }
        public virtual string Hotline { get; set; }
        public virtual string LinkFacebook { get; set; }
        public virtual string LinkYoutube { get; set; }
        public virtual string LinkReddit { get; set; }
        public virtual string LinkLinkedIn { get; set; }
        public virtual string Footer { get; set; }
        public virtual string LinkGioiThieu { get; set; }
        public virtual int? ThoiGianCapNhat { get; set; }
        public virtual float? GiaTriKichHoatHoaHong { get; set; }
        public virtual float? TiLeChiaHoaHong { get; set; }
        public virtual float? TiGiaVNDUSD { get; set; }
    }
}
