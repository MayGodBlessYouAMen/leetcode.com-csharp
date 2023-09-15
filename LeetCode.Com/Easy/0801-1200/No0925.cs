namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Long Pressed Name
    /// </summary>
    internal class No0925
    {
        /*
            解题思路：i和j分别指向name和typed的开头，i每次只能前进一步，j可以前进多步。如果i和j能匹配到结束，则ok
            

            1 <= name.length, typed.length <= 1000
            name and typed consist of only lowercase English letters.
         */
        public bool IsLongPressedName(string name, string typed)
        {

            if (typed.Length < name.Length)
            {
                return false;
            }

            //开头必须相等
            if (name[0] != typed[0])
            {
                return false;
            }

            int j = 1;
            for (int i = 1; i < name.Length; i++)
            {
                //j越界
                if (j >= typed.Length)
                {
                    return false;
                }

                //正确输入
                if (typed[j] == name[i])
                {
                    j++;
                    continue;
                }

                //剔除重复输入
                while (j < typed.Length && typed[j] == name[i - 1])
                {
                    j++;
                }

                //j越界
                if (j >= typed.Length)
                {
                    return false;
                }

                //剔除重复后不相等
                if (typed[j] != name[i])
                {
                    return false;
                }

                //判断下一个
                j++;
            }

            //末尾处理
            if (j < typed.Length)
            {
                while (j < typed.Length)
                {
                    if (typed[j] != name[name.Length - 1])
                    {
                        return false;
                    }
                    j++;
                }
            }

            return true;
        }
    }
}
