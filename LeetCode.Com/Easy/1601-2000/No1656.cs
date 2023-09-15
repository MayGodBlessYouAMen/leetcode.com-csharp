using System.Collections.Generic;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Design an Ordered Stream
    /// </summary>
    public class No1656
    {
        private string[] OrderArray;
        private int ptr = 0;

        public No1656(int n)
        //public OrderedStream(int n)
        {
            this.OrderArray = new string[n];
            this.ptr = 0;
        }

        public IList<string> Insert(int idKey, string value)
        {
            this.OrderArray[idKey - 1] = value;

            List<string> result = new List<string>();

            //如果ptr所在位置为空，则返回空
            if (string.IsNullOrWhiteSpace(this.OrderArray[this.ptr]))
            {
                return result.ToArray();
            }

            //如果ptr所在位置不为空，则从ptr开始往后遍历，直到找到空位或者结束，然后移动ptr位置到空位
            for (int i = idKey - 1; i < this.OrderArray.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(this.OrderArray[i]))
                {
                    this.ptr = i;
                    break;
                }

                if (!string.IsNullOrWhiteSpace(this.OrderArray[i]))
                {
                    result.Add(this.OrderArray[i]);
                }

                if (i == this.OrderArray.Length - 1)
                {
                    this.ptr = i + 1;
                    break;
                }
            }

            return result.ToArray();
        }
    }
}
