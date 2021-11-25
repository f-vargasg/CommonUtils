using CommonUtils.Log4NetTb;
using CommonUtils.OraDbTb;
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

        private void butTest_Click(object sender, EventArgs e)
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

        private void butTestLog4net_Click(object sender, EventArgs e)
        {
            Log4NetManager.WriteLog("Debug1", LogTypes.DebugLog);
        }
    }
}
