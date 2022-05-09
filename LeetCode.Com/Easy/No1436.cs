using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Destination City
    /// </summary>
    public class No1436
    {
        /*
            解题思路：将所有起点和终点分为两个集合，终点集合中不在起点集合里的元素，就是要找的终点
         */
        public string DestCity(IList<IList<string>> paths)
        {

            //统计所有起点
            Dictionary<string,int> startDic = new Dictionary<string, int>();
            foreach (var path in paths)
            {
                if (!startDic.ContainsKey(path[0]))
                {
                    startDic.Add(path[0], 1);
                }
                else
                {
                    startDic[path[0]]++;
                }
            }

            //遍历所有终点
            foreach (var path in paths)
            {
                if (startDic.ContainsKey(path[1]) && startDic[path[1]] > 0)
                {
                    startDic[path[1]]--;
                    continue;
                }

                //终点
                return path[1];
            }

            return "";
        }
    }
}
