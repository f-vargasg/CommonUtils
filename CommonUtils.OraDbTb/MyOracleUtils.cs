using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonUtils.OraDbTb
{
    public class MyOracleUtils
    {
        public static OracleDataReader ExecuteSqlStm(string psql, OracleConnection pConn)
        {
            OracleDataReader res = null;
            try
            {

                OracleCommand cmd = new OracleCommand(psql, pConn);
                cmd.CommandType = CommandType.Text;
                res = cmd.ExecuteReader();
            }
            catch (Exception)
            {

                throw;
            }
            return res;
        }

        public static DataSet ExecuteSqlStmDs(string psql, OracleConnection pConn)
        {
            DataSet ds = new DataSet();
            try
            {
                OracleDataAdapter adapter = new OracleDataAdapter(psql, pConn);

                adapter.Fill(ds);

            }
            catch (Exception)
            {

                throw;
            }
            return ds;
        }


        public static bool ConnectOk()
        {
            bool res = true;

            OracleDataReader dr;

            try
            {
                dr = MyOracleUtils.ExecuteSqlStm("SELECT SYSDATE FROM DUAL", ConnGl.Instance.Conn);
            }
            catch (Exception)
            {
                res = false;
            }

            return res;
        }

        /// <summary>
        /// Execute oracle sp
        /// </summary>
        /// <param name="spName"></param>
        /// <param name="oraCmd"></param>
        /// <param name="?"></param>
        public static void ExecOracleSp(string spName,
                                         OracleCommand oraCmd,
                                         OracleConnection pConn)
        {
            oraCmd.Connection = pConn;
            oraCmd.CommandType = CommandType.StoredProcedure;
            oraCmd.BindByName = true;

            oraCmd.CommandText = spName;
            oraCmd.ExecuteNonQuery();
        }


        public static void ExecOracleSp(string spName,
                                        List<OracleParameter> pparams,
                                        OracleConnection pConn)
        {
            OracleCommand oraCmd = pConn.CreateCommand();
            oraCmd.Connection = pConn;
            foreach (var item in pparams)
            {
                oraCmd.Parameters.Add(item);
            }

            oraCmd.CommandType = CommandType.StoredProcedure;
            oraCmd.BindByName = true;

            oraCmd.CommandText = spName;
            oraCmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Execute un Stored procedure (not Stored Function)
        /// </summary>
        /// <param name="spName"></param>
        /// <param name="pLstParam"></param>
        /// <param name="pConn"></param>
        public static OracleCommand ExecOracleSp2(string spName,
                                                  List<OracleParameter> pLstParam,
                                                  OracleConnection pConn)
        {
            OracleCommand cmd = pConn.CreateCommand();
            cmd.Connection = pConn;

            // add parameters
            foreach (var item in pLstParam)
            {
                cmd.Parameters.Add(item);
            }

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.BindByName = true;
            cmd.CommandText = spName;
            cmd.ExecuteNonQuery();
            return cmd;
        }

        /// <summary>
        /// Execute stored function (Sf)
        /// </summary>
        /// <param name="spName"></param>
        /// <param name="pLstParam"></param>
        /// <param name="pConn"></param>
        /// <returns></returns>
        public static object ExecOracleSf(string spName,
                                          List<OracleParameter> pLstParam,
                                          OracleConnection pConn)
        {
            object res = null;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = pConn;
            cmd.CommandText = spName;
            cmd.CommandType = CommandType.StoredProcedure;
            OracleParameter resultParam = new OracleParameter();
            resultParam.Direction = ParameterDirection.ReturnValue;
            resultParam.Size = 1000;
            cmd.Parameters.Add(resultParam);
            // add parameters
            foreach (var item in pLstParam)
            {
                cmd.Parameters.Add(item);
            }
            cmd.ExecuteNonQuery();
            res = resultParam.Value;
            return res;
        }

        public static object ExecOracleSf2(string spName, List<OracleParameter> pLstParam,
                                           OracleDbType pReturnType,
                                           OracleConnection pConn)
        {
            object res = null;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = pConn;
            cmd.CommandText = spName;
            cmd.CommandType = CommandType.StoredProcedure;
            OracleParameter resultParam = new OracleParameter("Return_value", pReturnType, ParameterDirection.ReturnValue);
            cmd.Parameters.Add(resultParam);
            // add parameters
            foreach (var item in pLstParam)
            {
                cmd.Parameters.Add(item);
            }
            cmd.ExecuteNonQuery();
            res = resultParam.Value;
            return res;
        }

        /// <summary>
        /// Execute dml: update, insert, delete
        /// </summary>
        /// <param name="sqlDml"></param>
        /// <param name="oraCmd"></param>
        /// <param name="pConn"></param>
        public static void ExecOracleStm(string sqlDml,
                                        OracleConnection pConn)
        {
            try
            {
                OracleCommand oraCmd = pConn.CreateCommand();
                // oraCmd.Connection = pConn;

                oraCmd.CommandType = CommandType.Text;
                //            oraCmd.BindByName = true;
                oraCmd.CommandText = sqlDml;
                oraCmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static OracleCommand ExecOracleStm2(string sqlDml,
                                 List<OracleParameter> pparams,
                                 OracleConnection pConn)
        {

            try
            {
                OracleCommand oraCmd = pConn.CreateCommand();
                oraCmd.Connection = pConn;
                foreach (var item in pparams)
                {
                    oraCmd.Parameters.Add(item);
                }
                oraCmd.CommandType = CommandType.Text;
                //            oraCmd.BindByName = true;
                oraCmd.CommandText = sqlDml;
                oraCmd.ExecuteNonQuery();

                return oraCmd;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static OracleParameter MakeParam()
        {
            OracleParameter res = new OracleParameter();

            return res;
        }

        public static OracleParameter MakeParam(string paramName,
                                                object pValue,
                                                OracleDbType ptype,
                                                ParameterDirection pdirParam)
        {
            OracleParameter res = new OracleParameter(paramName, ptype);
            res.Value = pValue;
            res.Direction = System.Data.ParameterDirection.Input;
            return res;
        }
    }
}
