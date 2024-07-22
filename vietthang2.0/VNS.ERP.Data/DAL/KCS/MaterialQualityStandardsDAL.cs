using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using VNS.Common;
using VNS.Utils;
using System.Data.Common;

namespace VNS.ERP.Data.KCS
{
  public  class MaterialQualityStandardsDAL : BaseDAL<MaterialQualityStandards>
    {
        public override int Insert(MaterialQualityStandards t)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_MaterialQualityStandards_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.AnsiString, 50, t.ItemCode));
                cmd.Parameters.Add(db.CreateParameter("@TechCode", System.Data.DbType.AnsiString, 10, t.TechCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, t.StartDate));
                cmd.Parameters.Add(db.CreateParameter("@ConditionType", System.Data.DbType.AnsiString, 20, t.ConditionType));
                cmd.Parameters.Add(db.CreateParameter("@ValueString", System.Data.DbType.String, 9, t.ValueString));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.AnsiString, 20, t.UserCreated));
                //cmd.Parameters.Add(db.CreateParameter("@UserUpdated",System.Data.DbType.AnsiString, 20, t.UserUpdated));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("MaterialQualityStandardsDAL", "Insert(MaterialQualityStandards t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
              
            
        }
      public override int Update(MaterialQualityStandards t)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_MaterialQualityStandards_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.AnsiString, 50, t.ItemCode));
                cmd.Parameters.Add(db.CreateParameter("@TechCode", System.Data.DbType.AnsiString, 10, t.TechCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, t.StartDate));
                cmd.Parameters.Add(db.CreateParameter("@ConditionType", System.Data.DbType.AnsiString, 20, t.ConditionType));
                cmd.Parameters.Add(db.CreateParameter("@ValueString", System.Data.DbType.String, 9, t.ValueString));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                //cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.AnsiString, 20, t.UserCreated));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.AnsiString, 20, t.UserUpdated));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                if (iError == 0)
                    iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                }
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("MaterialQualityStandardsDAL", "Update(MaterialQualityStandards t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

      public ListBase<MaterialQualityStandards> GetByItemCode(string itemCode)
        {
            DbDataReader reader = null;
            ListBase<MaterialQualityStandards> lstReturn = new ListBase<MaterialQualityStandards>();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_MaterialQualityStandards_SelectByItemCode";
                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, itemCode));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    MaterialQualityStandards obj = new MaterialQualityStandards(reader);
                    lstReturn.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("MaterialQualityStandardsDAL", "GetByItemCode(string itemCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }

      public override int Delete(MaterialQualityStandards t)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_MaterialQualityStandards_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, t.ItemCode));
                cmd.Parameters.Add(db.CreateParameter("@TechCode", System.Data.DbType.String, 10, t.TechCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, t.StartDate));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                if (iError == 0)
                    iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                }
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("MaterialQualityStandardsDAL", "Delete(MaterialQualityStandards t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
      public ListBase<MaterialQualityStandards> GetByDate(DateTime date)
      {
          DbDataReader reader = null;
          ListBase<MaterialQualityStandards> lstReturn = new ListBase<MaterialQualityStandards>();
          bool alreadyOpen = false;
          try
          {
              if (db.State != System.Data.ConnectionState.Open) db.Open();
              else alreadyOpen = true;
              DbCommand cmd = db.CreateCommand();
              cmd.CommandType = System.Data.CommandType.StoredProcedure;
              cmd.CommandText = "usp_MaterialQualityStandard_GetByDate";
              cmd.Parameters.Add(db.CreateParameter("@Date", System.Data.DbType.DateTime, 4, date));
              reader = db.ExecuteReader(cmd);
              while (reader.Read())
              {
                  MaterialQualityStandards obj = new MaterialQualityStandards(reader);
                  lstReturn.Add(obj);
              }
              reader.Close();
          }
          catch (Exception excp)
          {
              Write2Log.WriteLogs("MaterialQualityStandardsDAL", "GetByDate(DateTime date)", excp.Message);
          }
          finally
          {
              if (!alreadyOpen) db.Close();
          }
          return lstReturn;
      }
    }
}
