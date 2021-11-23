using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonUtils.StringTb
{
    public static class MyStringUtils
    {
        public static string entreComas(string ps)
        {
            return "'" + ps + "'";
        }

        public static string entreComas(string ps, bool quoted)
        {
            string res = "'" + ps + "'";
            if (quoted)
            {
                res = "q'[" + ps + "]'";
            }
            return res;
        }

        public static StreamReader ConvertStr2Stream(string strData)
        {
            // convertir string to stream
            byte[] byteArray = Encoding.UTF8.GetBytes(strData);
            MemoryStream stream = new MemoryStream(byteArray);
            StreamReader reader = new StreamReader(stream);
            return reader;
        }


        public static string fmtDateForDb(DateTime pval)
        {
            string res = string.Empty;

            res = string.Format("to_date ('{0:dd/MM/yyyy}', 'DD/MM/RRRR')", pval);

            return res;
        }

        public static string fmtDecimalForDb(Decimal pval)
        {
            string res = string.Empty;

            res = string.Format("{0:0.00}", pval);

            return res;
        }

        public static string fmtDoubleForDb(Double pval)
        {
            string res = string.Empty;

            res = string.Format("{0:0.000}", pval);

            return res;
        }

        public static List<String> createListFromStrSepBySemiColon(string strSepByChar, char pch)
        {
            String str = null;
            String[] strArr = null;
            int count = 0;
            str = strSepByChar;
            char[] splitchar = { pch };
            strArr = str.Split(splitchar);

            List<String> lstStr = new List<String>();

            for (count = 0; count <= strArr.Length - 1; count++)
            {
                if (!String.IsNullOrEmpty(strArr[count]))
                    lstStr.Add(strArr[count]);
            }
            return lstStr;
        }
    }
}
