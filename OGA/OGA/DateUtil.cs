using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGA
{
    public static class DateUtil
    {
        /// <summary>
        /// 月初を返却
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime StartOfMonth(DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1);
        }

        /// <summary>
        /// 月末を返却
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime EndOfMonth(DateTime date)
        {
            DateTime month = StartOfMonth(date);
            return month.AddMonths(1).AddDays(-1);
        }

    }
}
