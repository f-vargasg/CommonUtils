using CommonUtils.ClassTb;
using CommonUtils.DataGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonUtils.WinCompTb
{
    public partial class FrmPickList<T> : Form where T : class, new()
    {

        public List<T> LstData { get; set; }
        public List<ColumnGridBE> LstCols { get; set; }
        public DataGridTools DataGridTools { get; set; }
        public string ColumnsToHide { get; set; }

        public string DataPick { get; set; }

        public string ColumnDataPick { get; set; }   // nombre de la columna a retornar

        public string DescPick { get; set; }

        public string ColumnDescPick { get; set; }

        public FrmPickList()
        {
            InitializeComponent();
            InitMyComponents();
        }


        private void InitMyComponents()
        {
            StartPosition = FormStartPosition.CenterParent;
            DataGridTools = new DataGridTools(dgrData);
            DataGridTools.DgrdView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridTools.DgrdView.ReadOnly = true;

        }

        private void FrmPickList_Load(object sender, EventArgs e)
        {
            DataGridTools.FillDataGrid<T>(LstData);
            DataGridTools.HideColumns(ColumnsToHide);

            if (columnGridCmb.Items.Count <= 0)
            {
                foreach (var item in LstCols)
                {
                    if (DataGridTools.DgrdView.Columns[item.NomFisico].Visible)
                    {
                        DataGridTools.DgrdView.Columns[item.NomFisico].HeaderText = item.LblColumn;
                        columnGridCmb.Items.Add(item);
                    }
                }
                if (columnGridCmb.Items.Count > 0)
                {
                    columnGridCmb.SelectedIndex = 0;
                }
            }
           

            DataGridTools.AdjustColums();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            DataPick = Convert.ToString(DataGridTools.GetCurrentCellValue(ColumnDataPick));
            DescPick = Convert.ToString(DataGridTools.GetCurrentCellValue(ColumnDescPick));
            this.DialogResult = DialogResult.OK;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DataPick = string.Empty;
            this.DialogResult = DialogResult.Cancel;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            ColumnGridBE columnGridBE;
            string expresionFilter;

            if (toSearchTxt.Text == string.Empty)
            {
                dgrData.DataSource = LstData;
            }
            else
            {
                //dgrData.DataSource = LstData;
                columnGridBE = (ColumnGridBE)columnGridCmb.SelectedItem;
                List<T> lstFiltered = ClassUtils<T>.Filter(LstData, columnGridBE.NomFisico, toSearchTxt.Text);
                dgrData.DataSource= lstFiltered;
            }

        }

        private void DgrData_DoubleClick(object sender, EventArgs e)
        {
           OkBtn_Click(sender, e); 
        }
    }
}
