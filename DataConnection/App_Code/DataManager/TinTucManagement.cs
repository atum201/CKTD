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
    public class TinTucManagement
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

        public void themTinTuc(TinTuc TinTuc)
        {
            sessionManager.BeginTransaction();
            try
            {
                session.Save(TinTuc);
                sessionManager.CommitTransaction();
                //session.Close();
            }
            catch (HibernateException ex)
            {
                throw new DataException(ex.Message, ex);
            }
        }

        public void updateTinTuc(TinTuc TinTuc)
        {
            sessionManager.BeginTransaction();
            try
            {
                session.SaveOrUpdate(TinTuc);
                sessionManager.CommitTransaction();
            }
            catch (HibernateException ex)
            {
                throw new DataException(ex.Message, ex);
            }
        }

        public void xoaTinTuc(TinTuc TinTuc)
        {
            sessionManager.BeginTransaction();
            try
            {
                session.Delete(TinTuc);
                sessionManager.CommitTransaction();
            }
            catch (HibernateException ex)
            {
                throw new DataException(ex.Message, ex);
            }
        }

        public TinTuc getTinTucById(int iD)
        {
            try
            {
                TinTuc TinTuc = (TinTuc)session.Get<TinTuc>(iD);
                return TinTuc;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        
        public IList<TinTuc> getTinTuc(string condition)
        {
            try
            {
                string query = @"select * from TinTuc " + condition;
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(TinTuc));
                IList<TinTuc> listTinTuc = iQuery.List<TinTuc>();
                return listTinTuc;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IList<TinTuc> getTinTuc(string condition, string fieldAndTypeOrder, int pageId, int pageSize)
        {
            try
            {
                string query = @"select * from (
                                    select *,ROW_NUMBER() OVER (ORDER BY " + fieldAndTypeOrder + " ) STT from TinTuc " + condition + @" 
                                ) resultTable where resultTable.STT>" + ((pageId - 1) * pageSize) + " and resultTable.STT<=" + (pageId * pageSize);
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(TinTuc));
                IList<TinTuc> listTinTuc = iQuery.List<TinTuc>();
                return listTinTuc;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int countTinTuc(string condition)
        {
            try
            {
                string query = @"select count(ID) from TinTuc " + condition;
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
