using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [811]  Subdomain Visit Count
    /// </summary>
    public class No0811
    {
        public IList<string> SubdomainVisits(string[] cpdomains)
        {
            if (cpdomains == null || cpdomains.Length == 0) return null;

            Dictionary<string, int> mailDic = new Dictionary<string, int>();
            for (int i = 0; i < cpdomains.Length; i++)
            {
                //Each address will have either 1 or 2 "." characters.
                string[] temp1 = cpdomains[i].Split(' ');
                int count = int.Parse(temp1[0]);
                string mail = temp1[1];

                //添加全部
                if (!mailDic.Keys.Contains(mail))
                {
                    mailDic.Add(mail, count);
                }
                else
                {
                    mailDic[mail] = mailDic[mail] + count;
                }

                string[] temp2 = mail.Split('.');

                //添加尾巴
                {
                    string key = temp2[temp2.Length - 1];
                    if (!mailDic.Keys.Contains(key))
                    {
                        mailDic.Add(key, count);
                    }
                    else
                    {
                        mailDic[key] = mailDic[key] + count;
                    }
                }

                //添加后面俩
                {
                    if (temp2.Length == 3)
                    {
                        string key = temp2[1] + "." + temp2[2];
                        if (!mailDic.Keys.Contains(key))
                        {
                            mailDic.Add(key, count);
                        }
                        else
                        {
                            mailDic[key] = mailDic[key] + count;
                        }
                    }
                }
            }

            //Dictionary转list
            IList<string> list = new List<string>();
            foreach (var kv in mailDic)
            {
                list.Add(string.Format("{0} {1}", kv.Value, kv.Key));
            }

            return list;
        }
    }
}
