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
    public class LogRutTienHoaHongManagement
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

        public void themLogRutTienHoaHong(LogRutTienHoaHong LogRutTienHoaHong)
        {
            sessionManager.BeginTransaction();
            try
            {
                session.Save(LogRutTienHoaHong);
                sessionManager.CommitTransaction();
                //session.Close();
            }
            catch (HibernateException ex)
            {
                throw new DataException(ex.Message, ex);
            }
        }

        public void updateLogRutTienHoaHong(LogRutTienHoaHong LogRutTienHoaHong)
        {
            sessionManager.BeginTransaction();
            try
            {
                session.SaveOrUpdate(LogRutTienHoaHong);
                sessionManager.CommitTransaction();
            }
            catch (HibernateException ex)
            {
                throw new DataException(ex.Message, ex);
            }
        }

        public void xoaLogRutTienHoaHong(LogRutTienHoaHong LogRutTienHoaHong)
        {
            sessionManager.BeginTransaction();
            try
            {
                session.Delete(LogRutTienHoaHong);
                sessionManager.CommitTransaction();
            }
            catch (HibernateException ex)
            {
                throw new DataException(ex.Message, ex);
            }
        }

        public LogRutTienHoaHong getLogRutTienHoaHongById(int iD)
        {
            try
            {
                LogRutTienHoaHong LogRutTienHoaHong = (LogRutTienHoaHong)session.Get<LogRutTienHoaHong>(iD);
                return LogRutTienHoaHong;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public IList<LogRutTienHoaHong> getLogRutTienHoaHong()
        {
            try
            {
                string query = @"select * from LogRutTienHoaHong ";
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(LogRutTienHoaHong));
                IList<LogRutTienHoaHong> listLogRutTienHoaHong = iQuery.List<LogRutTienHoaHong>();
                return listLogRutTienHoaHong;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IList<LogRutTienHoaHong> getLogRutTienHoaHong(string condition)
        {
            try
            {
                string query = @"select * from LogRutTienHoaHong "+condition;
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(LogRutTienHoaHong));
                IList<LogRutTienHoaHong> listLogRutTienHoaHong = iQuery.List<LogRutTienHoaHong>();
                return listLogRutTienHoaHong;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int countLogRutTienHoaHong(string condition)
        {
            try
            {
                string query = @"select count(ID) from LogRutTienHoaHong " + condition;
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                int count = iQuery.UniqueResult<int>();
                return count;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public IList<LogRutTienHoaHong> getLogRutTienHoaHong(string condition,string fieldAndTypeOrder, int pageId, int pageSize)
        {
            try
            {
                string query = @"select * from (
                                    select *,ROW_NUMBER() OVER (ORDER BY " + fieldAndTypeOrder + " ) STT from LogRutTienHoaHong " + condition + @" 
                                ) resultTable where resultTable.STT>" + ((pageId - 1) * pageSize) + " and resultTable.STT<=" + (pageId * pageSize);
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(LogRutTienHoaHong));
                IList<LogRutTienHoaHong> listLogRutTienHoaHong = iQuery.List<LogRutTienHoaHong>();
                return listLogRutTienHoaHong;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
