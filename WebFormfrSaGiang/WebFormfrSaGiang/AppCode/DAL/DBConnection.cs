using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace WebFormfrSaGiang.AppCode.DAL
{
    public class DBConnection
    {
        public string strConn = WebConfigurationManager.ConnectionStrings["OMEGAWEBConnectionString"].ConnectionString;
        private SqlConnection conObject;
        public SqlConnection ConObject
        {
            get { return conObject; }
            set { conObject = value; }
        }
        public DBConnection()
        {
            conObject = new SqlConnection(strConn);

        }
        public void OpenConnect()
        {
            if (conObject.State == ConnectionState.Closed)
            {
                conObject.Open();
            }
        }
        public void OpenConnect(string strConn1)
        {
            conObject = new SqlConnection(strConn1);
            if (conObject.State == ConnectionState.Closed)
            {
                conObject.Open();
            }
        }
        public void CloseConnect()
        {
            if (conObject.State != ConnectionState.Closed)
            {
                conObject.Close();
            }
        }

        public DataTable getDataTable(string strSQL)
        {
            SqlCommand cmd = new SqlCommand(strSQL, conObject);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable getDataTable(SqlCommand cmd)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public SqlDataReader getDataReader(string strSQL)
        {
            SqlCommand cmd = new SqlCommand(strSQL, conObject);
            return cmd.ExecuteReader();
        }

        public SqlDataReader getDataReader(SqlCommand cmd)
        {
            return cmd.ExecuteReader();
        }

        public int excuteNonQuery(string strSQL)
        {
            SqlCommand cmd = new SqlCommand(strSQL, conObject);
            cmd.CommandType = CommandType.Text;
            return cmd.ExecuteNonQuery();
        }

        public int excuteNonQuery(SqlCommand cmd)
        {
            return cmd.ExecuteNonQuery();
        }

        public int excuteNonQuery_Connect(string strSQL)
        {
            OpenConnect();
            int x = excuteNonQuery(strSQL);
            CloseConnect();
            return x;
        }

        public string excuteWithTransaction(string strSQL)
        {
            int result = -1;
            string message = "";
            SqlTransaction sqlTran = null;

            try
            {
                OpenConnect();
                sqlTran = conObject.BeginTransaction();
                SqlCommand sqlCmd = new SqlCommand(strSQL, conObject, sqlTran);
                sqlCmd.CommandTimeout = 0;
                result = sqlCmd.ExecuteNonQuery();
                sqlTran.Commit();
                if (result == -1)
                {
                    message = "Thao tác thất bại.";
                }
            }
            catch (Exception ex)
            {
                if (sqlTran != null)
                    sqlTran.Rollback();
                message = ex.Message;
            }
            finally
            {
                CloseConnect();
                sqlTran.Dispose();
            }
            return message;
        }
        public object excuteScalar(string strSQL)
        {
            SqlCommand cmd = new SqlCommand(strSQL, conObject);
            cmd.CommandType = CommandType.Text;
            return cmd.ExecuteScalar();
        }

        public object excuteScalar_Connect(string strSQL)
        {
            OpenConnect();
            object x = excuteScalar(strSQL);
            CloseConnect();
            return x;
        }

        public object excuteScalar(SqlCommand cmd)
        {
            return cmd.ExecuteScalar();
        }
    }
}