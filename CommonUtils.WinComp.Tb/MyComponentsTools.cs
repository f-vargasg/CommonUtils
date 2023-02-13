using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonUtils.WinCompTb
{
    public class MyComponentsTools
    {
        public static void SetAccessToUserControls(IEnumerable ctrlCollection, bool pDispCtrls)
        {
            try
            {
                foreach (Control control in ctrlCollection)
                {
                    if (control is TextBox)
                    {
                        control.Enabled = pDispCtrls;
                    }
                    else if (control is ComboBox)
                    {
                        control.Enabled = pDispCtrls;
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
