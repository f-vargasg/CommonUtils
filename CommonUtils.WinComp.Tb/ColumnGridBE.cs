using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonUtils.WinCompTb
{
    public class ColumnGridBE
    {
        public int IdColumn { get; set; }

        public string LblColumn { get; set; }

        public string NomFisico { get; set; }


        public ColumnGridBE()
        {

        }

        public ColumnGridBE(int pIdColumn, string pLblColumn, string pNomFisico)
        {
            IdColumn = pIdColumn;
            LblColumn = pLblColumn; 
            NomFisico= pNomFisico;
        }

        public override string ToString()
        {
            return IdColumn.ToString() + " - " + LblColumn;
        }



    }
}
