using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonUtils.WinComp.Tb
{
    public partial class UCLoadFile: UserControl
    {


        public Label LblPathFname { 
            get { return lblPathFname; } 
        }

        public TextBox TxtPathFname
        {
            get { return txtPathFname; }

        }
        

        public Button ButBrowseFiles
        {
            get { return butBrowseFiles; }
        }

        public UCLoadFile()
        {
            InitializeComponent();
        }
    }
}
