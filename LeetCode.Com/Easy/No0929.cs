using System.Collections.Generic;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [929]  Unique Email Addresses
    /// </summary>
    public class No0929
    {
        public int NumUniqueEmails(string[] emails)
        {
            /* 思路：
                * 1.用@分隔，前面的是本地名，后面的是域名
                * 2.replace掉.
                * 3.用+分隔本地名，前面的是实际本地名
                * 4.用数组记录不重复的地址
                * */

            List<string> uniqueEailList = new List<string>();
            for (int i = 0; i < emails.Length; i++)
            {
                string email = GetUniqueEmail(emails[i]);
                if (!uniqueEailList.Contains(email))
                {
                    uniqueEailList.Add(email);
                }
            }
            return uniqueEailList.Count;
        }

        private string GetUniqueEmail(string email)
        {
            string[] arr1 = email.Split('@');
            return string.Format("{0}@{1}", arr1[0].Replace(".", "").Split('+')[0], arr1[1]);
        }
    }
}
