using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonUtils.DateTb
{
    public enum TimeMeasure
    {
        MinutesMeasure, DaysMeasure
    }

    public static class MyDateUtils
    {
        public const string FMT_TRUNCDATE = "dd/MM/yyyy";
        public const string FMT_DATETIMEHHMMSS = "dd/MM/yyyy HH:mm:ss";
        public const string FMT_DATETIMEHHMM = "dd/MM/yyyy HH:mm";

        private static double tiempoDuracionMin(DateTime timeIni,
                                               DateTime timeFin)
        {
            double res = 0.00;

            long diffTicks = (timeFin - timeIni).Ticks;

            res = TimeSpan.FromTicks(diffTicks).TotalMinutes;

            return res;
        }

        private static double tiempoDuracionDias(DateTime timeIni,
                                                DateTime timeFin)
        {
            double res = 0.00;

            long diffTicks = (timeFin - timeIni).Ticks;

            res = TimeSpan.FromTicks(diffTicks).TotalDays;

            return res;
        }

        public static double tiempoDuracion(DateTime timeIni,
                                            DateTime timeFin,
                                            TimeMeasure measure)
        {
            double res = 0.00;

            switch (measure)
            {
                case TimeMeasure.MinutesMeasure:
                    res = tiempoDuracionMin(timeIni, timeFin);
                    break;
                case TimeMeasure.DaysMeasure:
                    res = tiempoDuracionDias(timeIni, timeFin);
                    break;
                default:
                    break;
            }

            return res;
        }

        public static string ToChar(Nullable<DateTime> pDate)
        {
            string res;

            if (pDate == null)
            {
                res = "null";
            }
            else
            {
                res = "to_date ('" + pDate.Value.ToString(FMT_TRUNCDATE) + "', 'DD/MM/RRRR')";
            }
            return res;
        }

        public static string ToChar(DateTime pDate)
        {
            string res;


            res = "to_date ('" + pDate.ToString(FMT_TRUNCDATE) + "', 'DD/MM/RRRR')";

            return res;
        }

        public static string ToDateFmtStr(DateTime pDate)
        {
            string res;


            res = "to_date ('" + pDate.ToString(FMT_TRUNCDATE) + "', 'DD/MM/RRRR')";

            return res;
        }

        public static string ToDateFmtStr(DateTime pDate, string pFmtDate)
        {
            string res;


            res = "to_date ('" + pDate.ToString(pFmtDate) + "', 'DD/MM/RRRR')";

            return res;
        }

        public static DateTime ObtUltimoDiaMes(int pmes, int pyear)
        {
            DateTime res;

            // obterner ultimo dia del mes
            int dia = DateTime.DaysInMonth(pyear, pmes);
            string fecStr = dia.ToString("00") + "/" + pmes.ToString("00") + "/" + pyear.ToString("0000");

            res = DateTime.ParseExact(fecStr, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            return res;
        }
    }
}
