using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonUtils.OraDbTb
{
    public class ConnGl
    {
        private OracleConnection conn;

        public OracleConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }
        private string connStr;

        public string ConnStr
        {
            get { return connStr; }
            set { connStr = value; }
        }

        private ConnGl()
        {
            try
            {
                this.connStr = ConfigurationManager.AppSettings["connStr"];
                this.conn = new OracleConnection(connStr);
                this.conn.Open();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        // implementing singleton class
        private static ConnGl instance;

        public static ConnGl Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ConnGl();
                }
                return instance;
            }
        }
    }
}
