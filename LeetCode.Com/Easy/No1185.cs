namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Day of the Week
    /// </summary>
    public class No1185
    {
        /*
            解题思路：给定指定年月日，计算是星期几。给定年在1971和2100之间。
                        查询知道1971-01-01是星期五。
                        计算当前日期到1971-01-01之间的天数，然后除以7计算当前星期几。

                     The given dates are valid dates between the years 1971 and 2100.

         */
        public string DayOfTheWeek(int day, int month, int year)
        {
            int[] monthDays = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            string[] weekDays = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            int totalDays = 0;

            //年
            for (int i = 1971; i < year; i++)
            {
                totalDays += IsLeapYear(i) ? 366 : 365;
            }

            //月
            if (IsLeapYear(year))
            {
                monthDays[1] = 29;
            }
            for (int i = 0; i < month - 1; i++)
            {
                totalDays += monthDays[i];
            }

            //日
            totalDays += day;

            //计算当前日期的index。1971-01-01是星期五，补上前面4天，那么就是从星期一开始计算
            int index = (totalDays + (5 - 1)) % 7;
            return weekDays[index];
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
