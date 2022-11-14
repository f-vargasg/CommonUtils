using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonUtils.DataGrid
{
    public class DataGridTools
    {

        public DataGridView DgrdView { get; set; }

        public DataGridTools() { }

        public DataGridTools(DataGridView pDgrdV)
        {
            DgrdView = pDgrdV;
        }

        public void HideColumns(string colToHide)
        {
            string[] strings = colToHide.Split(',');
            foreach (var colStr in strings)
            {
                int ind = Convert.ToInt32(colStr);
                this.DgrdView.Columns[ind].Visible = false;
            }
        }
        public void FillDataGrid<T>(List<T> list)
        {
            var bindingList = new BindingList<T>(list);
            var source = new BindingSource(bindingList, null);
            this.DgrdView.DataSource = source;
        }

        public void FillDataGrid<T>(List<T> list,
                                    string plstColsToHide)
        {
            var bindingList = new BindingList<T>(list);
            var source = new BindingSource(bindingList, null);
            this.DgrdView.DataSource = source;
            HideColumns(plstColsToHide);
        }
    }
}
