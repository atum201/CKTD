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
    public class ThongTinHeThongManagement
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

        public void themThongTinHeThong(ThongTinHeThong ThongTinHeThong)
        {
            sessionManager.BeginTransaction();
            try
            {
                session.Save(ThongTinHeThong);
                sessionManager.CommitTransaction();
                //session.Close();
            }
            catch (HibernateException ex)
            {
                throw new DataException(ex.Message, ex);
            }
        }

        public void updateThongTinHeThong(ThongTinHeThong ThongTinHeThong)
        {
            sessionManager.BeginTransaction();
            try
            {
                session.SaveOrUpdate(ThongTinHeThong);
                sessionManager.CommitTransaction();
            }
            catch (HibernateException ex)
            {
                throw new DataException(ex.Message, ex);
            }
        }

        public void xoaThongTinHeThong(ThongTinHeThong ThongTinHeThong)
        {
            sessionManager.BeginTransaction();
            try
            {
                session.Delete(ThongTinHeThong);
                sessionManager.CommitTransaction();
            }
            catch (HibernateException ex)
            {
                throw new DataException(ex.Message, ex);
            }
        }

        public ThongTinHeThong getThongTinHeThongById(int iD)
        {
            try
            {
                ThongTinHeThong ThongTinHeThong = (ThongTinHeThong)session.Get<ThongTinHeThong>(iD);
                return ThongTinHeThong;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public IList<ThongTinHeThong> getThongTinHeThong()
        {
            try
            {
                string query = @"select * from ThongTinHeThong ";
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(ThongTinHeThong));
                IList<ThongTinHeThong> listThongTinHeThong = iQuery.List<ThongTinHeThong>();
                return listThongTinHeThong;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
