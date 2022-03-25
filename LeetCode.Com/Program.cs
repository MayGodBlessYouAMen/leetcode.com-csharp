using LeetCode.Com.Com;
using LeetCode.Com.Test;
using System;
using System.Collections.Generic;

namespace LeetCode.Com
{
    static class Program
    {
        /// <summary>
        /// 测试类
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Console.WriteLine("hello world");

            //Com.Utils.CreateModelClass();

            #region debug
            //{
            //    //todo:此函数有bug

            //    var root = Utils.CreateTreeNode(new List<int?>() { 5, 3, 6, 2, 4, null, 8, 1, null, null, null, 7, 9 });
            //    Console.WriteLine(root.ToConsoleString());  //输出的结果不正确,少了几个节点

            //}
            #endregion
            
            EasyTest.Start();
            MediumTest.Start();
            HardTest.Start();

            Console.ReadKey();
        }
    }
}
