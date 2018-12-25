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
    public class CKTDManagement
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
        #region CKTD_TaiKhoan

        
        public void themCKTD_TaiKhoan(CKTD_TaiKhoan CKTD_TaiKhoan)
        {
            sessionManager.BeginTransaction();
            try
            {
                session.Save(CKTD_TaiKhoan);
                sessionManager.CommitTransaction();
                //session.Close();
            }
            catch (HibernateException ex)
            {
                throw new DataException(ex.Message, ex);
            }
        }

        public void updateCKTD_TaiKhoan(CKTD_TaiKhoan CKTD_TaiKhoan)
        {
            sessionManager.BeginTransaction();
            try
            {
                session.SaveOrUpdate(CKTD_TaiKhoan);
                sessionManager.CommitTransaction();
            }
            catch (HibernateException ex)
            {
                throw new DataException(ex.Message, ex);
            }
        }

        public void xoaCKTD_TaiKhoan(CKTD_TaiKhoan CKTD_TaiKhoan)
        {
            sessionManager.BeginTransaction();
            try
            {
                session.Delete(CKTD_TaiKhoan);
                sessionManager.CommitTransaction();
            }
            catch (HibernateException ex)
            {
                throw new DataException(ex.Message, ex);
            }
        }

        public CKTD_TaiKhoan getCKTD_TaiKhoanById(int iD)
        {
            try
            {
                CKTD_TaiKhoan CKTD_TaiKhoan = (CKTD_TaiKhoan)session.Get<CKTD_TaiKhoan>(iD);
                return CKTD_TaiKhoan;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public IList<CKTD_TaiKhoan> getCKTD_TaiKhoan()
        {
            try
            {
                string query = @"select * from CKTD_TaiKhoan ";
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(CKTD_TaiKhoan));
                IList<CKTD_TaiKhoan> listCKTD_TaiKhoan = iQuery.List<CKTD_TaiKhoan>();
                return listCKTD_TaiKhoan;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IList<CKTD_TaiKhoan> getCKTD_TaiKhoan(string condition)
        {
            try
            {
                string query = @"select * from CKTD_TaiKhoan " + condition;
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(CKTD_TaiKhoan));
                IList<CKTD_TaiKhoan> listCKTD_TaiKhoan = iQuery.List<CKTD_TaiKhoan>();
                return listCKTD_TaiKhoan;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IList<CKTD_TaiKhoan> getCKTD_TaiKhoan(string condition, int pageIndex, int pageSize)
        {
            int num = pageIndex * pageSize - pageSize;
            try
            {
                string query = "SELECT * FROM ( SELECT *, ROW_NUMBER() OVER (ORDER BY ID desc) as row  FROM CKTD_TaiKhoan "+condition+" ) a WHERE a.row > " + num + " and a.row <= " + (num + pageSize);
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(CKTD_TaiKhoan));
                IList<CKTD_TaiKhoan> listCKTD_TaiKhoan = iQuery.List<CKTD_TaiKhoan>();
                return listCKTD_TaiKhoan;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int countCKTD_TaiKhoan(string condition)
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
                string e = ex.Message;
                return e.Length;
            }
        }

        public IList<CKTD_TaiKhoan> getCKTD_TaiKhoan(string condition, string fieldAndTypeOrder, int pageId, int pageSize)
        {
            try
            {
                string query = @"select * from (
                                    select *,ROW_NUMBER() OVER (ORDER BY " + fieldAndTypeOrder + " ) STT from CKTD_TaiKhoan " + condition + @" 
                                ) resultTable where resultTable.STT>" + ((pageId - 1) * pageSize) + " and resultTable.STT<=" + (pageId * pageSize);
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(CKTD_TaiKhoan));
                IList<CKTD_TaiKhoan> listCKTD_TaiKhoan = iQuery.List<CKTD_TaiKhoan>();
                return listCKTD_TaiKhoan;
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
                string query = @"select sum(GiaTri) from CKTD_TaiKhoan " + condition;
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                double result = iQuery.UniqueResult<double>();
                return (float)result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        #endregion
        #region CKTD_DonVi
        public void themCKTD_DonVi(CKTD_DonVi CKTD_DonVi)
        {
            sessionManager.BeginTransaction();
            try
            {
                session.Save(CKTD_DonVi);
                sessionManager.CommitTransaction();
                //session.Close();
            }
            catch (HibernateException ex)
            {
                throw new DataException(ex.Message, ex);
            }
        }

        public void updateCKTD_DonVi(CKTD_DonVi CKTD_DonVi)
        {
            sessionManager.BeginTransaction();
            try
            {
                session.SaveOrUpdate(CKTD_DonVi);
                sessionManager.CommitTransaction();
            }
            catch (HibernateException ex)
            {
                throw new DataException(ex.Message, ex);
            }
        }

        public void xoaCKTD_DonVi(CKTD_DonVi CKTD_DonVi)
        {
            sessionManager.BeginTransaction();
            try
            {
                session.Delete(CKTD_DonVi);
                sessionManager.CommitTransaction();
            }
            catch (HibernateException ex)
            {
                throw new DataException(ex.Message, ex);
            }
        }

        public CKTD_DonVi getCKTD_DonViById(int iD)
        {
            try
            {
                CKTD_DonVi CKTD_DonVi = (CKTD_DonVi)session.Get<CKTD_DonVi>(iD);
                return CKTD_DonVi;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public IList<CKTD_DonVi> getCKTD_DonVi()
        {
            try
            {
                string query = @"select * from CKTD_DonVi ";
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(CKTD_DonVi));
                IList<CKTD_DonVi> listCKTD_DonVi = iQuery.List<CKTD_DonVi>();
                return listCKTD_DonVi;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IList<CKTD_DonVi> getCKTD_DonVi(string condition)
        {
            try
            {
                string query = @"select * from CKTD_DonVi " + condition;
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(CKTD_DonVi));
                IList<CKTD_DonVi> listCKTD_DonVi = iQuery.List<CKTD_DonVi>();
                return listCKTD_DonVi;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IList<CKTD_DonVi> getCKTD_DonVi(string condition, int pageIndex, int pageSize)
        {
            int num = pageIndex * pageSize - pageSize;
            try
            {
                string query = "SELECT * FROM ( SELECT *, ROW_NUMBER() OVER (ORDER BY ID desc) as row  FROM CKTD_DonVi " + condition + " ) a WHERE a.row > " + num + " and a.row <= " + (num + pageSize);
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(CKTD_DonVi));
                IList<CKTD_DonVi> listCKTD_DonVi = iQuery.List<CKTD_DonVi>();
                return listCKTD_DonVi;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int countCKTD_DonVi(string condition)
        {
            try
            {
                string query = @"select count(ID) from CKTD_DonVi " + condition;
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                int count = iQuery.UniqueResult<int>();
                return count;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public IList<CKTD_DonVi> getCKTD_DonVi(string condition, string fieldAndTypeOrder, int pageId, int pageSize)
        {
            try
            {
                string query = @"select * from (
                                    select *,ROW_NUMBER() OVER (ORDER BY " + fieldAndTypeOrder + " ) STT from CKTD_DonVi " + condition + @" 
                                ) resultTable where resultTable.STT>" + ((pageId - 1) * pageSize) + " and resultTable.STT<=" + (pageId * pageSize);
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(CKTD_DonVi));
                IList<CKTD_DonVi> listCKTD_DonVi = iQuery.List<CKTD_DonVi>();
                return listCKTD_DonVi;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion
        #region CKTD_DichVuCong
        public void themCKTD_DichVuCong(CKTD_DichVuCong CKTD_DichVuCong)
        {
            sessionManager.BeginTransaction();
            try
            {
                session.Save(CKTD_DichVuCong);
                sessionManager.CommitTransaction();
                //session.Close();
            }
            catch (HibernateException ex)
            {
                throw new DataException(ex.Message, ex);
            }
        }

        public void updateCKTD_DichVuCong(CKTD_DichVuCong CKTD_DichVuCong)
        {
            sessionManager.BeginTransaction();
            try
            {
                session.SaveOrUpdate(CKTD_DichVuCong);
                sessionManager.CommitTransaction();
            }
            catch (HibernateException ex)
            {
                throw new DataException(ex.Message, ex);
            }
        }

        public void xoaCKTD_DichVuCong(CKTD_DichVuCong CKTD_DichVuCong)
        {
            sessionManager.BeginTransaction();
            try
            {
                session.Delete(CKTD_DichVuCong);
                sessionManager.CommitTransaction();
            }
            catch (HibernateException ex)
            {
                throw new DataException(ex.Message, ex);
            }
        }

        public CKTD_DichVuCong getCKTD_DichVuCongById(int iD)
        {
            try
            {
                CKTD_DichVuCong CKTD_DichVuCong = (CKTD_DichVuCong)session.Get<CKTD_DichVuCong>(iD);
                return CKTD_DichVuCong;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public IList<CKTD_DichVuCong> getCKTD_DichVuCong()
        {
            try
            {
                string query = @"select * from CKTD_DichVuCong ";
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(CKTD_DichVuCong));
                IList<CKTD_DichVuCong> listCKTD_DichVuCong = iQuery.List<CKTD_DichVuCong>();
                return listCKTD_DichVuCong;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IList<CKTD_DichVuCong> getCKTD_DichVuCong(string condition)
        {
            try
            {
                string query = @"select * from CKTD_DichVuCong " + condition;
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(CKTD_DichVuCong));
                IList<CKTD_DichVuCong> listCKTD_DichVuCong = iQuery.List<CKTD_DichVuCong>();
                return listCKTD_DichVuCong;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public IList<CKTD_DichVuCong> getCKTD_DichVuCong(string condition, int pageIndex, int pageSize)
        {
            int num = pageIndex * pageSize - pageSize;
            try
            {
                string query = "SELECT * FROM ( SELECT *, ROW_NUMBER() OVER (ORDER BY ID desc) as row  FROM CKTD_DichVuCong " + condition + " ) a WHERE a.row > " + num + " and a.row <= " + (num + pageSize);
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(CKTD_DichVuCong));
                IList<CKTD_DichVuCong> listCKTD_DichVuCong = iQuery.List<CKTD_DichVuCong>();
                return listCKTD_DichVuCong;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public int countCKTD_DichVuCong(string condition)
        {
            try
            {
                string query = @"select count(ID) from CKTD_DichVuCong " + condition;
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                int count = iQuery.UniqueResult<int>();
                return count;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public IList<CKTD_DichVuCong> getCKTD_DichVuCong(string condition, string fieldAndTypeOrder, int pageId, int pageSize)
        {
            try
            {
                string query = @"select * from (
                                    select *,ROW_NUMBER() OVER (ORDER BY " + fieldAndTypeOrder + " ) STT from CKTD_DichVuCong " + condition + @" 
                                ) resultTable where resultTable.STT>" + ((pageId - 1) * pageSize) + " and resultTable.STT<=" + (pageId * pageSize);
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(CKTD_DichVuCong));
                IList<CKTD_DichVuCong> listCKTD_DichVuCong = iQuery.List<CKTD_DichVuCong>();
                return listCKTD_DichVuCong;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion
        #region CKTD_VanBan
        public void themCKTD_VanBan(CKTD_VanBan CKTD_VanBan)
        {
            sessionManager.BeginTransaction();
            try
            {
                session.Save(CKTD_VanBan);
                sessionManager.CommitTransaction();
                //session.Close();
            }
            catch (HibernateException ex)
            {
                throw new DataException(ex.Message, ex);
            }
        }

        public void updateCKTD_VanBan(CKTD_VanBan CKTD_VanBan)
        {
            sessionManager.BeginTransaction();
            try
            {
                session.SaveOrUpdate(CKTD_VanBan);
                sessionManager.CommitTransaction();
            }
            catch (HibernateException ex)
            {
                throw new DataException(ex.Message, ex);
            }
        }

        public void xoaCKTD_VanBan(CKTD_VanBan CKTD_VanBan)
        {
            sessionManager.BeginTransaction();
            try
            {
                session.Delete(CKTD_VanBan);
                sessionManager.CommitTransaction();
            }
            catch (HibernateException ex)
            {
                throw new DataException(ex.Message, ex);
            }
        }

        public CKTD_VanBan getCKTD_VanBanById(int iD)
        {
            try
            {
                CKTD_VanBan CKTD_VanBan = (CKTD_VanBan)session.Get<CKTD_VanBan>(iD);
                return CKTD_VanBan;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public IList<CKTD_VanBan> getCKTD_VanBan()
        {
            try
            {
                string query = @"select * from CKTD_VanBan ";
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(CKTD_VanBan));
                IList<CKTD_VanBan> listCKTD_VanBan = iQuery.List<CKTD_VanBan>();
                return listCKTD_VanBan;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IList<CKTD_VanBan> getCKTD_VanBan(string condition)
        {
            try
            {
                string query = @"select * from CKTD_VanBan " + condition;
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(CKTD_VanBan));
                IList<CKTD_VanBan> listCKTD_VanBan = iQuery.List<CKTD_VanBan>();
                return listCKTD_VanBan;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public IList<CKTD_VanBan> getCKTD_VanBan(string condition, int pageIndex, int pageSize)
        {
            int num = pageIndex * pageSize - pageSize;
            try
            {
                string query = "SELECT * FROM ( SELECT *, ROW_NUMBER() OVER (ORDER BY ID desc) as row  FROM CKTD_VanBan " + condition + " ) a WHERE a.row > " + num + " and a.row <= " + (num + pageSize);
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(CKTD_VanBan));
                IList<CKTD_VanBan> listCKTD_VanBan = iQuery.List<CKTD_VanBan>();
                return listCKTD_VanBan;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public int countCKTD_VanBan(string condition)
        {
            try
            {
                string query = @"select count(ID) from CKTD_VanBan " + condition;
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                int count = iQuery.UniqueResult<int>();
                return count;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public IList<CKTD_VanBan> getCKTD_VanBan(string condition, string fieldAndTypeOrder, int pageId, int pageSize)
        {
            try
            {
                string query = @"select * from (
                                    select *,ROW_NUMBER() OVER (ORDER BY " + fieldAndTypeOrder + " ) STT from CKTD_VanBan " + condition + @" 
                                ) resultTable where resultTable.STT>" + ((pageId - 1) * pageSize) + " and resultTable.STT<=" + (pageId * pageSize);
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(CKTD_VanBan));
                IList<CKTD_VanBan> listCKTD_VanBan = iQuery.List<CKTD_VanBan>();
                return listCKTD_VanBan;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion
        #region TaiKhoan_DonVi
        public void themTaiKhoan_DonVi(TaiKhoan_DonVi TaiKhoan_DonVi)
        {
            sessionManager.BeginTransaction();
            try
            {
                session.Save(TaiKhoan_DonVi);
                sessionManager.CommitTransaction();
                //session.Close();
            }
            catch (HibernateException ex)
            {
                throw new DataException(ex.Message, ex);
            }
        }

        public void updateTaiKhoan_DonVi(TaiKhoan_DonVi TaiKhoan_DonVi)
        {
            sessionManager.BeginTransaction();
            try
            {
                session.SaveOrUpdate(TaiKhoan_DonVi);
                sessionManager.CommitTransaction();
            }
            catch (HibernateException ex)
            {
                throw new DataException(ex.Message, ex);
            }
        }

        public void xoaTaiKhoan_DonVi(TaiKhoan_DonVi TaiKhoan_DonVi)
        {
            sessionManager.BeginTransaction();
            try
            {
                session.Delete(TaiKhoan_DonVi);
                sessionManager.CommitTransaction();
            }
            catch (HibernateException ex)
            {
                throw new DataException(ex.Message, ex);
            }
        }

        public TaiKhoan_DonVi getTaiKhoan_DonViById(int iD)
        {
            try
            {
                TaiKhoan_DonVi TaiKhoan_DonVi = (TaiKhoan_DonVi)session.Get<TaiKhoan_DonVi>(iD);
                return TaiKhoan_DonVi;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public IList<TaiKhoan_DonVi> getTaiKhoan_DonVi()
        {
            try
            {
                string query = @"select * from TaiKhoan_DonVi ";
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(TaiKhoan_DonVi));
                IList<TaiKhoan_DonVi> listTaiKhoan_DonVi = iQuery.List<TaiKhoan_DonVi>();
                return listTaiKhoan_DonVi;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IList<TaiKhoan_DonVi> getTaiKhoan_DonVi(string condition)
        {
            try
            {
                string query = @"select * from TaiKhoan_DonVi " + condition;
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(TaiKhoan_DonVi));
                IList<TaiKhoan_DonVi> listTaiKhoan_DonVi = iQuery.List<TaiKhoan_DonVi>();
                return listTaiKhoan_DonVi;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public IList<TaiKhoan_DonVi> getTaiKhoan_DonVi(string condition, int pageIndex, int pageSize)
        {
            int num = pageIndex * pageSize - pageSize;
            try
            {
                string query = "SELECT * FROM ( SELECT *, ROW_NUMBER() OVER (ORDER BY ID desc) as row  FROM TaiKhoan_DonVi " + condition + " ) a WHERE a.row > " + num + " and a.row <= " + (num + pageSize);
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(TaiKhoan_DonVi));
                IList<TaiKhoan_DonVi> listTaiKhoan_DonVi = iQuery.List<TaiKhoan_DonVi>();
                return listTaiKhoan_DonVi;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public int countTaiKhoan_DonVi(string condition)
        {
            try
            {
                string query = @"select count(ID) from TaiKhoan_DonVi " + condition;
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                int count = iQuery.UniqueResult<int>();
                return count;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public IList<TaiKhoan_DonVi> getTaiKhoan_DonVi(string condition, string fieldAndTypeOrder, int pageId, int pageSize)
        {
            try
            {
                string query = @"select * from (
                                    select *,ROW_NUMBER() OVER (ORDER BY " + fieldAndTypeOrder + " ) STT from TaiKhoan_DonVi " + condition + @" 
                                ) resultTable where resultTable.STT>" + ((pageId - 1) * pageSize) + " and resultTable.STT<=" + (pageId * pageSize);
                ISQLQuery iQuery = session.CreateSQLQuery(query);
                iQuery.AddEntity(typeof(TaiKhoan_DonVi));
                IList<TaiKhoan_DonVi> listTaiKhoan_DonVi = iQuery.List<TaiKhoan_DonVi>();
                return listTaiKhoan_DonVi;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion
    }
}
