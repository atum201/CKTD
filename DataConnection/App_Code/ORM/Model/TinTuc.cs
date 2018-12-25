using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConnection.App_Code.ORM.Model
{
    public class TinTuc
    {
        public virtual int ID { get; set; }
        public virtual string TieuDe { get; set; }
        public virtual string NoiDung { get; set; } 
        public virtual string LoaiTinTuc { get; set; }
        public virtual DateTime? NgayTao { get; set; }
        public virtual string TrangThai { get; set; }


    }
}
