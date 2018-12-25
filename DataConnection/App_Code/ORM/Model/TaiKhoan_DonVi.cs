using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConnection.App_Code.ORM.Model
{
    public class TaiKhoan_DonVi
    {
        public virtual int ID { get; set; }
        public virtual CKTD_DonVi DonVi { get; set; }
        public virtual CKTD_TaiKhoan TaiKhoan { get; set; }
        public virtual int TrangThai { get; set; }
    }
}
