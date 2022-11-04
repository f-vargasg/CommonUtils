using CommonUtils.StringTb;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CommonUtils.DataLayer
{
    public enum DataLayerTypes : ushort
    {
        Unknow = 0,
        EnNumeric = 1,
        EnVarchar = 2,
        EnDate = 3
    }
    public class SqlCondition
    {
        public static string BuildCondition<T>(string pFldName,
                                               string pOpCondition,
                                               T pValue)
        {
            string res = string.Empty;

            Type type = typeof(T);
            res = string.Empty;
            if (pValue != null)
            {
                if (type == typeof(int) || type == typeof(long) ||
                    type == typeof(double))
                {
                    res += (pFldName + " " + pOpCondition + " " + pValue);
                }
                else if (type == typeof(string))
                {
                    string str =Convert.ToString(pValue);
                    if (str != String.Empty)
                    {
                        str = MyStringUtils.EntreComas(str);
                        res += (pFldName + " " + pOpCondition + " " + str); ;
                    }
                     
                }
                else if (type == typeof(DateTime))
                {
                    res += (pFldName + " " + pOpCondition + " " + MyStringUtils.FmtDateForDb(Convert.ToDateTime(pValue)));
                }
            }

            return res;
        }

        public static string AddCondition(string pCond,
                                          string pNewCond)
        {
            string res = pCond;

            res += (pCond.Length > 0 ? " AND " : string.Empty) + pNewCond;

            return res;
        }


        public static string AddConditionToSql(string psql,
                                               string pCond)
        {
            string res = psql + (pCond.Length > 0 ? " WHERE " + pCond : string.Empty);

            return res ;
        }

    }
}
