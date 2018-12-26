using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConnection.App_Code.ORM.Model
{
    public class CKTD_DonVi
    {
        public virtual int ID { get; set; }
        public virtual string TenDonVi { get; set; }
        public virtual int? TrangThai { get; set; }
        public virtual int? LoaiDonVi { get; set; }
        public virtual int? STT { get; set; }
    }
}
