using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Move Zeroes
    /// </summary>
    public class No0283
    {
        public void MoveZeroes(int[] nums)
        {
            //大前提:不能重新建数组，只能在原数组内移动

            //思路1：0冒泡 => Accepted 562ms
            /*
            for(int i=0;i<nums.Length-1;i++)
            {
                for(int j=0;j<nums.Length-1-i;j++)
                {
                    if(nums[j]==0)
                    {
                        nums[j]=nums[j+1];
                        nums[j+1]=0;
                    }
                }
            }
            */

            //思路2.考虑优化  => 462 ms ?
            //例:12034056
            //12不用动，03交换，04交换，b变成了12340056，
            //再找到5和第一个0交换，6和第一个0交换
            int startZeroIndex = -1;
            int endZeroIndex = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    if (startZeroIndex == -1)
                    {
                        startZeroIndex = i;
                        endZeroIndex = i;
                    }

                    for (int j = i; j < nums.Length; j++)
                    {
                        if (nums[j] == 0)
                        {
                            endZeroIndex = j;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (endZeroIndex < nums.Length - 1)
                    {
                        nums[startZeroIndex] = nums[endZeroIndex + 1];
                        nums[endZeroIndex + 1] = 0;
                        startZeroIndex++;
                        endZeroIndex++;
                        i = endZeroIndex;  //下次直接从0串的下一位开始
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    if (startZeroIndex != -1)
                    {
                        nums[startZeroIndex] = nums[i];
                        nums[i] = 0;
                        startZeroIndex++;
                        endZeroIndex++;
                        i = endZeroIndex;  //下次直接从0串的下一位开始
                    }
                }
            }

        }
    }
}
