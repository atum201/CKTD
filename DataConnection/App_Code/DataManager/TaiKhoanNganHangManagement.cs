using DataConnection.App_Code.ORM.Core;
using DataConnection.App_Code.ORM.Model;
using NHibernate;
using NHibernate.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConnection.App_Code.DataManager
{
    public class TaiKhoanNganHangManagement
    {
        public NHibernateSessionManager sessionManager
        {
            get
            {
                return NHibernateSessionManager.Instance;
            }
        }
        public ISession session
        {
            get
            {
                return sessionManager.GetSession();


            }
        }

        public void themTaiKhoanNganHang(TaiKhoanNganHang TaiKhoanNganHang)
        {
            sessionManager.BeginTransaction();
            try
            {
                session.Save(TaiKhoanNganHang);
                sessionManager.CommitTransaction();
                //session.Close();
            }
            catch (HibernateException ex)
            {
                throw new DataException(ex.Message, ex);
            }
        }

        public void updateTaiKhoanNganHang(TaiKhoanNganHang TaiKhoanNganHang)
        {
            sessionManager.BeginTransaction();
            try
            {
                session.SaveOrUpdate(TaiKhoanNganHang);
                sessionManager.CommitTransaction();
            }
            catch (HibernateException ex)
            {
                throw new DataException(ex.Message, ex);
            }
        }

        public void xoaTaiKhoanNganHang(TaiKhoanNganHang TaiKhoanNganHang)
        {
            sessionManager.BeginTransaction();
            try
            {
                session.Delete(TaiKhoanNganHang);
                sessionManager.CommitTransaction();
            }
            catch (HibernateException ex)
            {
                throw new DataException(ex.Message, ex);
            }
        }

        public TaiKhoanNganHang getTaiKhoanNganHangById(int iD)
        {
            try
            {
                TaiKhoanNganHang TaiKhoanNganHang = (TaiKhoanNganHang)session.Get<TaiKhoanNganHang>(iD);
                return TaiKhoanNganHang;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IList<TaiKhoanNganHang> getTaiKhoanNganHang(string condition)
        {
            try
            {
                string query = @"select * from TaiKhoanNganHang " + condition;
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(TaiKhoanNganHang));
                IList<TaiKhoanNganHang> listTaiKhoanNganHang = iQuery.List<TaiKhoanNganHang>();
                return listTaiKhoanNganHang;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IList<TaiKhoanNganHang> getTaiKhoanNganHang()
        {
            try
            {
                string query = @"select * from TaiKhoanNganHang ";
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(TaiKhoanNganHang));
                IList<TaiKhoanNganHang> listTaiKhoanNganHang = iQuery.List<TaiKhoanNganHang>();
                return listTaiKhoanNganHang;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IList<TaiKhoanNganHang> getTaiKhoanNganHang(string condition, string fieldAndTypeOrder, int pageId, int pageSize)
        {
            try
            {
                string query = @"select * from (
                                    select *,ROW_NUMBER() OVER (ORDER BY " + fieldAndTypeOrder + " ) STT from TaiKhoanNganHang " + condition + @" 
                                ) resultTable where resultTable.STT>" + ((pageId - 1) * pageSize) + " and resultTable.STT<=" + (pageId * pageSize);
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(TaiKhoanNganHang));
                IList<TaiKhoanNganHang> listTaiKhoanNganHang = iQuery.List<TaiKhoanNganHang>();
                return listTaiKhoanNganHang;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int countTaiKhoanNganHang(string condition)
        {
            try
            {
                string query = @"select count(ID) from TaiKhoanNganHang " + condition;
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                int count = iQuery.UniqueResult<int>();
                return count;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }


        public IList<TaiKhoanNganHang> getHanMucTrongNgayTaiKhoanNganHang()
        {
            try
            {
                string query = @"
select ID,TenChuThe,SoTaiKhoan,
		(case 
			when TongGiaoDich IS NULL then HanMucTrongNgay 
			else (HanMucTrongNgay-TongGiaoDich)
		 end
		) HanMucTrongNgay,TrangThai
from TaiKhoanNganHang tknh 
left join 
(
select IDTaiKhoanNganHang,SUM(GiaTri) TongGiaoDich from DonHang 
where NgayThanhToan >= CAST(CURRENT_TIMESTAMP AS DATE) and NgayThanhToan < DATEADD(DD, 1, CAST(CURRENT_TIMESTAMP AS DATE)) 
group by IDTaiKhoanNganHang
) temp
on tknh.ID=temp.IDTaiKhoanNganHang

";
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(TaiKhoanNganHang));
                IList<TaiKhoanNganHang> listTaiKhoanNganHang = iQuery.List<TaiKhoanNganHang>();
                return listTaiKhoanNganHang;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
