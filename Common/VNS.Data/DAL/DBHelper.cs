using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Configuration;
using System.IO;
namespace VNS.Data.DAL
{
    public class DBHelper
    {
        public static string SERVER;// = ConfigurationManager.AppSettings["Server"];
        public static string USERNAME;// = ConfigurationManager.AppSettings["UserName"];
        public static string PASSWORD;// = ConfigurationManager.AppSettings["Password"];
        public static string DATABASENAME;// = ConfigurationManager.AppSettings["Database"];
        public static int CommandTimeout = 300;
        static DBHelper()
        {
            LoadDBConfig();
        }

        public static void LoadDBConfig()
        {
            SERVER = ConfigurationManager.AppSettings["Server"];
            DATABASENAME = ConfigurationManager.AppSettings["Database"];
            USERNAME = ConfigurationManager.AppSettings["UserName"];
            PASSWORD = VNS.Security.Crypto.DecryptString( ConfigurationManager.AppSettings["Password"]);            
        }
        #region Properties
        private System.Data.Common.DbConnection mConnection;

        public DbConnection Connection
        {
            get { return mConnection; }
            set { mConnection = value; }

        }

        private string mConString;

        public string ConnectionString
        {
            get { return mConString; }
            set { mConString = value; }
        }

        private DbTransaction mTransaction;

        public DbTransaction Transaction
        {
            get { return mTransaction; }
            set { mTransaction = value; }
        }
        private ConnectionState mState;

        public ConnectionState State
        {
            get { return mConnection.State; }

        }
        #endregion
        #region Constructors

        public DBHelper()
        {
            //if (ConfigurationManager.ConnectionStrings.Count > 0)
            //{
            //    ConnectionStringSettings cnStringSetting = ConfigurationManager.ConnectionStrings[0];
            //    mFactory = DbProviderFactories.GetFactory(cnStringSetting.ProviderName);
            //    mConnection = mFactory.CreateConnection();
            //    mConnection.ConnectionString = cnStringSetting.ConnectionString;
            //}
            //else
            //{
            try
            {
                DbConnectionStringBuilder builder;
                mFactory = DbProviderFactories.GetFactory(ConfigurationManager.AppSettings["Provider"]);

                builder = mFactory.CreateConnectionStringBuilder();

                builder.Add("User Id", DBHelper.USERNAME);
                builder.Add("Password", DBHelper.PASSWORD);
                builder.Add("Connection Timeout", int.Parse(ConfigurationManager.AppSettings["TimeOut"]));
                if (mFactory is OleDbFactory)
                {
                    builder.Add("Data Source", DBHelper.DATABASENAME);
                    builder.Add("Provider", "Microsoft.Jet.Oledb.4.0");
                }
                else
                {
                    builder.Add("Server", DBHelper.SERVER);
                    builder.Add("Database", DBHelper.DATABASENAME);
                }

                mConnection = mFactory.CreateConnection();
                mConnection.ConnectionString = builder.ConnectionString;
            }
            catch { }
            //}
        }
        public DBHelper(string ConnectionString):this(ConnectionString,ConfigurationManager.AppSettings["Provider"])
        {            
            
        }
        public DBHelper(string ConnectionString,string providerName)
        {
            mFactory = DbProviderFactories.GetFactory(providerName);
            mConnection = mFactory.CreateConnection();
            mConnection.ConnectionString = ConnectionString;
            
        }
        #endregion

        #region Methods
        public DbCommand CreateCommand()
        {
            DbCommand cmd = mFactory.CreateCommand();
            cmd.Connection = mConnection;
            cmd.CommandTimeout = CommandTimeout;
            return cmd;
        }

        public DbDataAdapter CreateAdapter()
        {
            return mFactory.CreateDataAdapter();
        }
        #region CreateParameter overloads
        /// <summary>
        /// Create parammeter overloads
        /// </summary>
        /// <returns></returns>
        public DbParameter CreateParameter()
        {
            return mFactory.CreateParameter();
        }
        public DbParameter CreateParameter(string paramName)
        {
            DbParameter param = mFactory.CreateParameter();
            param.ParameterName = paramName;
            return param;
        }
        public DbParameter CreateParameter(string paramName, DbType paramType)
        {
            DbParameter param = mFactory.CreateParameter();
            param.ParameterName = paramName;
            param.DbType = paramType;
            return param;
        }
        public DbParameter CreateParameter(string paramName, DbType paramType, int paramLength)
        {
            DbParameter param = mFactory.CreateParameter();
            param.ParameterName = paramName;
            param.DbType = paramType;
            param.Size = paramLength;
            return param;
        }
        public DbParameter CreateParameter(string paramName, DbType paramType, int paramLength, object value)
        {
            DbParameter param = mFactory.CreateParameter();
            param.ParameterName = paramName;
            param.DbType = paramType;
            param.Size = paramLength;
            param.Value = value;
            return param;
        }

        public DbParameter CreateParameter(string paramName, DbType paramType, int paramLength, object value, ParameterDirection paramDirection)
        {
            DbParameter param = mFactory.CreateParameter();
            param.ParameterName = paramName;
            param.DbType = paramType;
            param.Size = paramLength;
            param.Value = value;
            param.Direction = paramDirection;
            return param;
        }

        #endregion
        public int ExecuteNonQuery(string cmdText)
        {
            try
            {
                DbCommand cmd = CreateCommand();
                cmd.CommandText = cmdText;
                return this.ExecuteNonQuery(cmd);
            }
            catch (DbException e)
            {
                
                throw e;
            }
        }
        public int ExecuteNonQuery(DbCommand cmd)
        {
            try
            {
                this.Open();
                cmd.Transaction = mTransaction;
                cmd.ExecuteNonQuery();
                return 0;
            }
            catch (Exception e)
            {
                if (e is DbException)
                    return (e as DbException).ErrorCode;
                else throw e;
                //throw e;

            }
            

        }
        /// <summary>
        /// Executes a command text and returns a DataTable
        /// </summary>
        /// <param name="cmdText">Command Text to execute</param>
        /// <returns>Result DataTable</returns>
        public DataTable ExecuteTable(string cmdText)
        {
            try
            {
                DbCommand cmd = CreateCommand();
                cmd.CommandText = cmdText;
                return this.ExecuteTable(cmd);
            }
            catch (DbException e)
            {

                throw e;
            }
            
        }

        public DataTable ExecuteTable(DbCommand cmd)
        {
            try
            {
                cmd.Transaction = mTransaction;
                this.Open();
                DbDataAdapter adp = mFactory.CreateDataAdapter();
                DataTable dt = new DataTable();
                adp.SelectCommand = cmd;
                adp.Fill(dt);
                adp.Dispose();
                return dt;
            }
            catch (DbException e)
            {

                throw e;
            }
            
        }

        /// <summary>
        /// Executes a command text and returns a DataSet
        /// </summary>
        /// <param name="cmdText">Command text to execute</param>
        /// <returns>DataSet</returns>
        public DataSet ExecuteDataSet(string cmdText)
        {
            try
            {
                DbCommand cmd = CreateCommand();
                cmd.CommandText = cmdText;
                return this.ExecuteDataSet(cmd);
            }
            catch (DbException e)
            {

                throw e;
            }
        }
        public DataSet ExecuteDataSet(DbCommand cmd)
        {
            try
            {
                cmd.Transaction = mTransaction;
                this.Open();
                DbDataAdapter adp = mFactory.CreateDataAdapter();
                DataSet ds = new DataSet();
                adp.SelectCommand = cmd;
                adp.Fill(ds);
                adp.Dispose();
                return ds;
            }
            catch (DbException e)
            {

                throw e;
            }
        }
       
        /// <summary>
        /// Executes a command text and return a Scalar value
        /// </summary>
        /// <param name="cmdText">Command text to execute</param>
        /// <returns>Scalar value</returns>
        public object ExecuteScalar(string cmdText)
        {
            try
            {
                DbCommand cmd = CreateCommand();
                cmd.CommandText = cmdText;
                return this.ExecuteScalar(cmd);
            }
            catch (DbException e)
            {

                throw e;
            }
        }
        public object ExecuteScalar(DbCommand cmd)
        {
            try
            {
                this.Open();
                cmd.Transaction = mTransaction;
                return cmd.ExecuteScalar();
            }
            catch (DbException e)
            {

                throw e;
            }
            
        }

        /// <summary>
        /// Executes a command text and returns a DataReader
        /// </summary>
        /// <param name="cmdText"></param>
        /// <returns></returns>
        public DbDataReader ExecuteReader(string cmdText)
        {
            try
            {
                DbCommand cmd = CreateCommand();
                
                cmd.CommandText = cmdText;
                return this.ExecuteReader(cmd);
            }
            catch (DbException e)
            {

                throw e;
            }
        }
        public DbDataReader ExecuteReader(DbCommand cmd)
        {
            try
            {
                this.Open();
                cmd.Transaction = mTransaction;
                return cmd.ExecuteReader();
            }
            catch (DbException e)
            {

                throw e;
            }

        }
                
        public DbDataReader ExecuteReader(DbCommand cmd,CommandBehavior cobe)
        {
            try
            {
                return cmd.ExecuteReader(cobe);
            }
            catch (DbException e)
            {

                throw e;
            }
        }

        public void BeginTransaction()
        {
            if (mConnection.State != ConnectionState.Open)
                mConnection.Open();
            mTransaction = mConnection.BeginTransaction();

        }
        public void Commit()
        {
            if (mTransaction != null)
            {
                mTransaction.Commit();
                this.Close();
                mTransaction = null;
            }

        }
        public void Rollback()
        {
            if (mTransaction != null)
            {
                mTransaction.Rollback();
                this.Close();
                mTransaction = null;
            }
        }

        public void Open()
        {
            if (mConnection.State!= ConnectionState.Open)            
                mConnection.Open();
            
        }

        public void Close()
        {
            if ((mConnection.State == ConnectionState.Open) && mTransaction==null)
                mConnection.Close();
            
        }

        /// <summary>
        /// Runs a script file
        /// </summary>
        /// <param name="filePath"></param>
        public int RunScriptFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                StreamReader reader = File.OpenText(filePath);
                int ret = this.RunScript(reader);
                reader.Close();
                return ret;
            }
            return -1;

        }

        /// <summary>
        /// Runs script blocks from a string
        /// </summary>
        /// <param name="script"></param>
        public int RunScript(string script)
        {
            StringReader reader = new StringReader(script);
            int ret = this.RunScript(reader);
            reader.Close();
            return ret;
        }

        
        /// <summary>
        /// Runs script blocks from a TextReader
        /// </summary>
        /// <param name="reader"></param>
        public int RunScript(TextReader reader)
        {          
            
            string line;
            StringBuilder text = new StringBuilder();
            //this.BeginTransaction();
            try
            {
                
                DbCommand cmd = this.CreateCommand();
                while ((line = reader.ReadLine()) !=null)
                {                    
                    if (line.Equals("GO", StringComparison.OrdinalIgnoreCase) && text.Length>0 )
                    {
                        cmd.CommandText = text.ToString();
                        this.ExecuteNonQuery(cmd);
                        text.Remove(0, text.Length);
                    }
                    else if (!line.Equals("GO", StringComparison.OrdinalIgnoreCase) && !line.Trim().Equals(string.Empty))
                        text.AppendLine(line);
                }
                //this.Commit();
                return 0;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message + text.ToString());
                //this.Rollback();
                Utils.Write2Log.WriteLogs(this.GetType().Name, "RunScript(TextReader reader)", ex.Message + "\r\n" + text.ToString());
                return -1;
            }
            finally
            {
                this.Close();
            }
            
        }
        #endregion
        #region Privates
        DbProviderFactory mFactory;

        #endregion
    }

}
