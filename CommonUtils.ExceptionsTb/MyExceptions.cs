using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CommonUtils.ExceptionsTb
{
    public class MyExceptions
    {
        /// <summary>
        /// Dada una exception retorna el nombre de la rutina invocadora
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        public static string GetRoutineName (Exception ex)
        {
            string res = string.Empty;

            var s = new StackTrace(ex);
            var thisasm = Assembly.GetExecutingAssembly();
            var methodname = s.GetFrames().Select(f => f.GetMethod()).First(m => m.Module.Assembly == thisasm).Name;

            return res;

        }
    }
}
