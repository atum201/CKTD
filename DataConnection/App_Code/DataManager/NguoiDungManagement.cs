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
    public class NguoiDungManagement
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

        public void themNguoiDung(NguoiDung NguoiDung)
        {
            sessionManager.BeginTransaction();
            try
            {
                session.Save(NguoiDung);
                sessionManager.CommitTransaction();
                //session.Close();
            }
            catch (HibernateException ex)
            {
                throw new DataException(ex.Message, ex);
            }
        }

        public void updateNguoiDung(NguoiDung NguoiDung)
        {
            sessionManager.BeginTransaction();
            try
            {
                session.SaveOrUpdate(NguoiDung);
                sessionManager.CommitTransaction();
            }
            catch (HibernateException ex)
            {
                throw new DataException(ex.Message, ex);
            }
        }

        public void xoaNguoiDung(NguoiDung NguoiDung)
        {
            sessionManager.BeginTransaction();
            try
            {
                session.Delete(NguoiDung);
                sessionManager.CommitTransaction();
            }
            catch (HibernateException ex)
            {
                throw new DataException(ex.Message, ex);
            }
        }

        public NguoiDung getNguoiDungById(int iD)
        {
            try
            {
                NguoiDung NguoiDung = (NguoiDung)session.Get<NguoiDung>(iD);
                return NguoiDung;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public IList<NguoiDung> getNguoiDung()
        {
            try
            {
                string query = @"select * from NguoiDung ";
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(NguoiDung));
                IList<NguoiDung> listNguoiDung = iQuery.List<NguoiDung>();
                return listNguoiDung;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IList<NguoiDung> getNguoiDung(string condition)
        {
            try
            {
                string query = @"select * from NguoiDung "+condition;
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(NguoiDung));
                IList<NguoiDung> listNguoiDung = iQuery.List<NguoiDung>();
                return listNguoiDung;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool xacThucNguoiDung(string tenDangNhap,string password)
        {
            try
            {
                string query = @"select  * from NguoiDung where TenDangNhap=N'"+tenDangNhap+"' and MatKhau=N'"+password+"'";
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(NguoiDung));
                IList<NguoiDung> listNguoiDung = iQuery.List<NguoiDung>();
                return (listNguoiDung == null || listNguoiDung.Count == 0) ? false : true;
            }
            catch (Exception ex)
            {
                return false;
            }

            
        }


        public IList<NguoiDung> getNguoiDung(string condition, string fieldAndTypeOrder, int pageId, int pageSize)
        {
            try
            {
                string query = @"select * from (
                                    select *,ROW_NUMBER() OVER (ORDER BY " + fieldAndTypeOrder + " ) STT from NguoiDung " + condition + @" 
                                ) resultTable where resultTable.STT>" + ((pageId - 1) * pageSize) + " and resultTable.STT<=" + (pageId * pageSize);
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(NguoiDung));
                IList<NguoiDung> listNguoiDung = iQuery.List<NguoiDung>();
                return listNguoiDung;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int countNguoiDung(string condition)
        {
            try
            {
                string query = @"select count(ID) from NguoiDung " + condition;
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                int count = iQuery.UniqueResult<int>();
                return count;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

    }
}
