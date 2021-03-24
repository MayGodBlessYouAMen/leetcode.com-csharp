using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    public class No0371
    {
        public int GetSum(int a, int b)
        {

            /*
            //思路:先转换成二进制，再通过逐位比较计算
            int[] binaryA = ChangeIntToBinary(a);
            int[] binaryB = ChangeIntToBinary(b);

            //A存放相加的结果，B里存放进位。循环相加直到B中全为0
            while(HasOne(binaryB))
            {
               Sum(binaryA,binaryB);
            }

            //走上了绝路，二进制数组如何转化成int...
            return binaryA;
            */

            while (b != 0)
            {
                int temp = a;
                a = a ^ b;
                b = (temp & b) << 1;
            }

            return a;
        }

        /*
        public bool HasOne(int[] b)
        {
            bool hasOne = false;
            for(int i=0;i<32;i++)
            {
                if(b[i]==1)
                {
                    hasOne=true;
                    break;
                }
            }

            return hasOne;
        }

        public void Sum(int[] a, int[] b)
        {
            for(int i=0;i<32;i++)
            {

                if(a[i]==0&&b[i]==0)
                {
                    //do nothing
                }
                else if(a[i]==1&&b[i]==1)
                {
                    a[i]=0;
                    b[i]=1; //存进位
                }
                else
                {
                    a[i]=1;
                    b[i]=0;
                }
            }
        }

        public int[] ChangeIntToBinary(int num)
        {
            int n = num;
            int[] arr = new int[32];
            int maxindex = 0;
            while (true)
            {
                arr[maxindex] = n % 2;
                n = n / 2;
                if (n == 0)
                {
                    break;
                }
                maxindex++;
            }
            return arr;
        }
        */
    }
}
