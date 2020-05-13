using LeetCode.Com.Com;
using LeetCode.Com.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Test
{
    public class MediumTest
    {
        public static void Start()
        {
            #region No0002
            No0002 no0002 = new No0002();
            Console.WriteLine(no0002.AddTwoNumbers(Utils.CreateListNode(new List<int>() { 2, 4, 3 }), Utils.CreateListNode(new List<int>() { 5, 6, 4 })).ToString());
            Console.WriteLine(no0002.AddTwoNumbers(Utils.CreateListNode(new List<int>() { 2, 4, 3 }), Utils.CreateListNode(new List<int>() { 5, 6 })).ToString());
            Console.WriteLine(no0002.AddTwoNumbers(Utils.CreateListNode(new List<int>() { 2, 4 }), Utils.CreateListNode(new List<int>() { 5, 6, 4 })).ToString());
            Console.WriteLine(no0002.AddTwoNumbers(Utils.CreateListNode(new List<int>() { 2, 4, 3 }), Utils.CreateListNode(new List<int>() { })).ToString());
            Console.WriteLine(no0002.AddTwoNumbers(Utils.CreateListNode(new List<int>() { }), Utils.CreateListNode(new List<int>() { 5, 6, 4 })).ToString());
            Console.WriteLine(no0002.AddTwoNumbers(Utils.CreateListNode(new List<int>() { }), Utils.CreateListNode(new List<int>() { })));
            Console.WriteLine(no0002.AddTwoNumbers(Utils.CreateListNode(new List<int>() { 5}), Utils.CreateListNode(new List<int>() { 5})).ToString());
            #endregion
        }
    }
}
