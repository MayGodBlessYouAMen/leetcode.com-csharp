using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Day of the Year
    /// </summary>
    internal class No1154
    {
        /*
            解题思路：前面月份天数相加，再加上当前日期，即可。注意闰年的2月有29天。
         */
        public int DayOfYear(string date)
        {
            //date格式：yyyy-MM-dd

            List<int> monthDays = new List<int>() { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            int year = int.Parse(date.Substring(0, 4));
            int month = int.Parse(date.Substring(5, 2));
            int day = int.Parse(date.Substring(8, 2));

            if (IsLeapYear(year))
            {
                monthDays[1] = 29;
            }

            int days = 0;
            for (int i = 0; i < month - 1; i++)
            {
                days += monthDays[i];
            }

            days += day;

            return days;

        }

        /// <summary>
        /// 闰年判断
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        private bool IsLeapYear(int year)
        {
            /*
                闰年定义：1.能被400整除
                          2.能被4整除，但是不能被100整除。
                满足1或者2其中一条，就是闰年
             */

            if (year % 400 == 0)
            {
                return true;
            }

            if (year % 4 == 0 && year % 100 != 0)
            {
                return true;
            }

            return false;
        }
    }
}
