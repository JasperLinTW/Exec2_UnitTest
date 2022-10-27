using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispan.DockTrade
{
    public class program
    {
        
    }
    public class TaiwainStockUtility
    {
        /// <summary>
        /// 

        /// </summary>
        /// 日期必需在星期一~星期五時間必需介於9:00 ~ 13:30
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool IsTradingTime(DateTime dt)
        {
            bool isDateTime = DateTime.TryParse(dt.ToString(), out dt);
            if (isDateTime == false)
            {
                throw new Exception("您輸入的日期不符合格式");
            }
            
            string dtString = dt.ToString("HH:mm");
            DateTime dateTime = Convert.ToDateTime(dtString);
            DateTime start = Convert.ToDateTime("09:00");
            DateTime end = Convert.ToDateTime("13:30");

            int week = (int)dt.DayOfWeek;
            
            if (week > 0 && week <= 5 && dateTime >= start && dateTime <= end)
            {
                return true;
            }
            return false;
        }

        

    }
}
