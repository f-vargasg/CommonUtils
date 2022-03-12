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
    public partial class UCSelectedFile : UserControl
    {

        public Label LblPathFname
        {
            get { return lblPathFname; }
            set { lblPathFname = value; }
        }

        public TextBox TxtPathFname
        {
            get { return txtPathFname; }

        }

        public Button ButBrowseFiles
        {
            get { return butBrowseFiles; }
        }

        public OpenFileDialog OpenFileDlg { get; set; }

        public UCSelectedFile()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {
            this.OpenFileDlg = new OpenFileDialog();
            this.butBrowseFiles.Click += ButBrowseFiles_Click;
        }

        private void ButBrowseFiles_Click(object sender, EventArgs e)
        {
            string currentFilePath = TxtPathFname.Text;
            TxtPathFname.Text = GetFilePath(currentFilePath);
        }

        private string GetFilePath(string pOldFilePath)
        {
            string res = string.Empty;
            var fileContent = string.Empty;
            var filePath = string.Empty;

            OpenFileDlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            // OpenFileDlg.Filter = "docx files (*.docx)|*.docx|doc files (*.doc)|*.doc|xlsx files (*.xlsx)|*.xlsx|xls files (*.xls)|*.xls|All files (*.*)|*.*";
            OpenFileDlg.FilterIndex = 2;
            OpenFileDlg.RestoreDirectory = true;

            res = pOldFilePath;
            if (OpenFileDlg.ShowDialog() == DialogResult.OK)
            {
                res = OpenFileDlg.FileName;
            }

            return res;
        }
    }
}
