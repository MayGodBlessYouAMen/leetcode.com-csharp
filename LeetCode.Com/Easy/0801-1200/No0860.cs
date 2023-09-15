namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Lemonade Change
    /// </summary>
    internal class No0860
    {
        /*
            解题思路：每杯柠檬水5刀，顾客按队列排，每个顾客只能买一杯，顾客支付的面额是5/10/20中的一种。
                      最开始摊主手上没有零钱。如果能为每个顾客找零，则返回true，否则返回false
         */
        public bool LemonadeChange(int[] bills)
        {
            //定义用于存放摊主零钱数量的数组。分别存放5，10，20的数量
            int[] changes = new int[3] { 0, 0, 0 };

            for (int i = 0; i < bills.Length; i++)
            {
                //5元，无需找零，直接收钱
                if (bills[i] == 5)
                {
                    changes[0]++;
                    continue;
                }

                //10元，需要找零5元
                if (bills[i] == 10)
                {
                    //无5元零钱，返回false
                    if (changes[0] == 0)
                    {
                        return false;
                    }

                    //有零钱。5元数量-1，10元数量+1
                    changes[0]--;
                    changes[1]++;
                    continue;
                }

                //20元，优先找零10+5，其次才是5+5+5
                if (bills[i] == 20)
                {
                    //找零10+5
                    if (changes[1] > 0 && changes[0] > 0)
                    {
                        changes[1]--;
                        changes[0]--;
                        changes[2]++;

                        continue;
                    }

                    //找零5+5+5
                    if (changes[1] == 0 && changes[0] >= 3)
                    {
                        changes[0] = changes[0] - 3;
                        changes[2]++;

                        continue;
                    }

                    //无法找零
                    return false;
                }
            }

            return true;
        }
    }
}
