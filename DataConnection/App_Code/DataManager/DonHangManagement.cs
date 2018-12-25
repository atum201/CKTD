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
    public class DonHangManagement
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

        public void themDonHang(DonHang DonHang)
        {
            sessionManager.BeginTransaction();
            try
            {
                session.Save(DonHang);
                sessionManager.CommitTransaction();
                //session.Close();
            }
            catch (HibernateException ex)
            {
                throw new DataException(ex.Message, ex);
            }
        }

        public void updateDonHang(DonHang DonHang)
        {
            sessionManager.BeginTransaction();
            try
            {
                session.SaveOrUpdate(DonHang);
                sessionManager.CommitTransaction();
            }
            catch (HibernateException ex)
            {
                throw new DataException(ex.Message, ex);
            }
        }

        public void xoaDonHang(DonHang DonHang)
        {
            sessionManager.BeginTransaction();
            try
            {
                session.Delete(DonHang);
                sessionManager.CommitTransaction();
            }
            catch (HibernateException ex)
            {
                throw new DataException(ex.Message, ex);
            }
        }

        public DonHang getDonHangById(int iD)
        {
            try
            {
                DonHang DonHang = (DonHang)session.Get<DonHang>(iD);
                return DonHang;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public IList<DonHang> getDonHang()
        {
            try
            {
                string query = @"select * from DonHang ";
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(DonHang));
                IList<DonHang> listDonHang = iQuery.List<DonHang>();
                return listDonHang;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IList<DonHang> getDonHang(string condition)
        {
            try
            {
                string query = @"select * from DonHang "+condition;
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(DonHang));
                IList<DonHang> listDonHang = iQuery.List<DonHang>();
                return listDonHang;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int countDonHang(string condition)
        {
            try
            {
                string query = @"select count(ID) from CKTD_TaiKhoan " + condition;
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                int count = iQuery.UniqueResult<int>();
                return count;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public IList<DonHang> getDonHang(string condition,string fieldAndTypeOrder, int pageId, int pageSize)
        {
            try
            {
                string query = @"select * from (
                                    select *,ROW_NUMBER() OVER (ORDER BY " + fieldAndTypeOrder + " ) STT from DonHang " + condition + @" 
                                ) resultTable where resultTable.STT>" + ((pageId - 1) * pageSize) + " and resultTable.STT<=" + (pageId * pageSize);
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(DonHang));
                IList<DonHang> listDonHang = iQuery.List<DonHang>();
                return listDonHang;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public float tongGiaTriGiaoDich(string condition)
        {
            try
            {
                string query = @"select sum(GiaTri) from DonHang " + condition;
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                double result = iQuery.UniqueResult<double>();
                return (float) result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
