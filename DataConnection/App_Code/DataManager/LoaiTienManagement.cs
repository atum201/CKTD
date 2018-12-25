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
    public class LoaiTienManagement
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

        public void themLoaiTien(LoaiTien LoaiTien)
        {
            sessionManager.BeginTransaction();
            try
            {
                session.Save(LoaiTien);
                sessionManager.CommitTransaction();
                //session.Close();
            }
            catch (HibernateException ex)
            {
                throw new DataException(ex.Message, ex);
            }
        }

        public void updateLoaiTien(LoaiTien LoaiTien)
        {
            sessionManager.BeginTransaction();
            try
            {
                session.SaveOrUpdate(LoaiTien);
                sessionManager.CommitTransaction();
            }
            catch (HibernateException ex)
            {
                throw new DataException(ex.Message, ex);
            }
        }

        public void xoaLoaiTien(LoaiTien LoaiTien)
        {
            sessionManager.BeginTransaction();
            try
            {
                session.Delete(LoaiTien);
                sessionManager.CommitTransaction();
            }
            catch (HibernateException ex)
            {
                throw new DataException(ex.Message, ex);
            }
        }

        public LoaiTien getLoaiTienById(int iD)
        {
            try
            {
                LoaiTien LoaiTien = (LoaiTien)session.Get<LoaiTien>(iD);
                return LoaiTien;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public IList<LoaiTien> getLoaiTien()
        {
            try
            {
                string query = @"select * from LoaiTien ";
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(LoaiTien));
                IList<LoaiTien> listLoaiTien = iQuery.List<LoaiTien>();
                return listLoaiTien;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IList<LoaiTien> getLoaiTien(string condition)
        {
            try
            {

                string query = @"select * from LoaiTien "+condition;
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(LoaiTien));
                IList<LoaiTien> listLoaiTien = iQuery.List<LoaiTien>();
                return listLoaiTien;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IList<LoaiTien> getLoaiTien(string condition, string fieldAndTypeOrder, int pageId, int pageSize)
        {
            try
            {
                string query = @"select * from (
                                    select *,ROW_NUMBER() OVER (ORDER BY " + fieldAndTypeOrder + " ) STT from LoaiTien " + condition + @" 
                                ) resultTable where resultTable.STT>" + ((pageId - 1) * pageSize) + " and resultTable.STT<=" + (pageId * pageSize);
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(LoaiTien));
                IList<LoaiTien> listLoaiTien = iQuery.List<LoaiTien>();
                return listLoaiTien;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int countLoaiTien(string condition)
        {
            try
            {
                string query = @"select count(ID) from LoaiTien " + condition;
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
