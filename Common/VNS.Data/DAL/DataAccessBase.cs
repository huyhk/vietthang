using System;
using System.Collections.Generic;
using System.Text;

namespace VNS.Data.DAL
{
    public class DataAccessBase
    {
        #region Privates

        protected DBHelper db;
        public DBHelper DBHelper
        {
            get { return db; }
            set { db = value; }
        }

        #endregion

        #region Constructors

        public DataAccessBase()
        {
            db = new DBHelper();
        }
        public DataAccessBase(DBHelper dbHelper)
        {
            db = dbHelper;
        }
        public void SetDBHelper(DBHelper dbHelper)
        {
            db = dbHelper;
        }

        #endregion

        #region public methods

        public void Open()
        {
            this.db.Open();
        }
        public void Close()
        {
            this.db.Close();
        }

        public void BeginTransaction()
        {
            this.db.BeginTransaction();
        }
        public void Rollback()
        {
            this.db.Rollback();
        }
        public void Commit()
        {
            this.db.Commit();            
        }

        #endregion
    }
}
