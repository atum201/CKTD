using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConnection.App_Code.ORM.Model
{
    public class LogRutTienHoaHong
    {
        public virtual int ID { get; set; }
        public virtual NguoiDung NguoiDung { get; set; }
        public virtual string IDsDonHang { get; set; }
        public virtual string TrangThai { get; set; }
        public virtual DateTime? NgayYeuCau { get; set; }
    }
}
