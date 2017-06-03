using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace EduCommerce.Data
{
    public class driver
    {

        private SqlConnection cn;

        public SqlConnection Connection
        {
            set { cn=value; }
            get { return cn; }
        }

        public driver()
        {   cn = new SqlConnection("Data Source=MEHMETFG\\MEHMETFG;Initial Catalog=KariyerPoliklinikDB;Integrated Security=True");
            //  if (ConfigurationManager.ConnectionStrings["Baglantim"] == null)
            //Data Source=MEHMETG\MFGSERVER;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
            //      throw new ApplicationException("Lütfen, Web.Config dosyasına veritabanına bağlatı tanımı yapınız !");
            // }
            //  else 
            //  {

            //}
        }
        public driver(string ConnectionString)
        {
            cn = new SqlConnection(ConnectionString);
        }

        public void executeSql(string sql)
        {
            try
            {
                executeCommand(getCommand(sql));
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        public void executeSql(string sql, params object[] paramValues)
        {

            try
            {
                executeCommand(getCommand(sql, paramValues));
            }
            catch (Exception x)
            {
                throw x;
            }

        }

        public void executeProc(string procName, params object[] paramValues)
        {

            SqlCommand cmd = getCommand(procName, paramValues);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                executeCommand(cmd);
            }
            catch (Exception x)
            {
                throw x;
            }

        }

        private SqlCommand getCommand(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, cn);
            return cmd;
           
        }
        
        public  SqlCommand getCmd(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn.Open();
                    cmd.CommandText=sql;
                    cmd.Connection=cn;
                    
            }
            catch (Exception x)
            {
                throw x;
            }
            
            
            finally
            {
                cn.Close();
            }
            return cmd;

           
        }
        private SqlCommand getCommand(string sql, params object[] paramValues)
        {
            SqlCommand cmd = getCommand(sql);
            for (int i = 0; i < paramValues.Length; i++)
                cmd.Parameters.AddWithValue("@p" + (i + 1).ToString(), paramValues[i]);
            return cmd;
          
        }

        private int executeCommand(SqlCommand cmd)
        {
            int i = -1;
            try
            {
                if (cn.State == ConnectionState.Closed) cn.Open();
                i = cmd.ExecuteNonQuery();
            }
            catch (Exception x)
            {
                throw x;
            }
            finally
            {
                cn.Close();
            }
            return i;
        }

        public DataTable getTable(string sql)
        {
            return getTable(getCommand(sql));
            cn.Close();
        }

        public DataTable getTable(string sql, params object[] paramValues)
        {
            return getTable(getCommand(sql, paramValues));
            cn.Close();
        }

        private DataTable getTable(SqlCommand cmd)
        {
            DataTable dt = new DataTable("RESULTSET");
            
            try
            {
                if (this.Connection.State == ConnectionState.Closed) this.Connection.Open();
                IDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);

            }
            catch (Exception x)
            {
                throw x;
            }
            finally
            {
                cn.Close();
            }
            return dt;
        }
    }
}