using CommonUtils.Log4NetTb;
using CommonUtils.OraDbTb;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTestUtils
{
    /// <summary>
    /// Al archivo del log4net.xml en la propiedad "Copiar en el Directorio Salida"  poner la opción 
    /// "Copiar Siempre". Si está opción no se pone da un evento
    /// </summary>
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ButTest_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = null;
                 ds = MyOracleUtils.ExecuteSqlStmDs("Select 1 from dual", ConnGl.Instance.Conn);
                 MessageBox.Show("Connecion OKKKKK!!!!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButTestLog4net_Click(object sender, EventArgs e)
        {
            Log4NetManager.WriteLog("Debug1", LogTypes.DebugLog);
        }

        public string ObtenerCodigoInterCodigoInterno(int pCodCatEnte,
                                                       string pNomTabla,
                                                       string pDesValorExt,
                                                       string pIndValidaExiste)
        {
            string res = string.Empty;
            try
            {
                OracleParameter param;
                List<OracleParameter> lstParams = new List<OracleParameter>();
                param = MyOracleUtils.MakeParam("PCOD_CATENTE_N", pCodCatEnte, OracleDbType.Int32, ParameterDirection.Input);
                lstParams.Add(param);

                param = MyOracleUtils.MakeParam("PNOM_TABLA", pNomTabla, OracleDbType.Varchar2,ParameterDirection.Input);
                param.Size = 500;
                lstParams.Add(param);

                param = MyOracleUtils.MakeParam("PDES_VALOREXT", pDesValorExt, OracleDbType.Varchar2,ParameterDirection.Input);
                param.Size = 500;
                lstParams.Add(param);

                param = MyOracleUtils.MakeParam("pind_validaExist", pIndValidaExiste, OracleDbType.Varchar2,ParameterDirection.Input);
                param.Size = 500;
                lstParams.Add(param);

                Console.WriteLine(lstParams.Count.ToString());

                object obj = MyOracleUtils.ExecOracleSf2("ge_pambhomologa.obtener_cod_INTERNO", lstParams, OracleDbType.Varchar2, ConnGl.Instance.Conn);

                res = Convert.ToString(obj);

            }
            catch (Exception)
            {

                throw;
            }
            return res;
        }
        private void ButTestFunction_Click(object sender, EventArgs e)
        {
            try
            {
                string res = ObtenerCodigoInterCodigoInterno(2, "GE_AMBMONEDA", "CRC", "N");
                txtOutPut.Text = res;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
