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
            //No0002 no0002 = new No0002();
            //Console.WriteLine(no0002.AddTwoNumbers(Utils.CreateListNode(new List<int>() { 2, 4, 3 }), Utils.CreateListNode(new List<int>() { 5, 6, 4 })).ToString());
            //Console.WriteLine(no0002.AddTwoNumbers(Utils.CreateListNode(new List<int>() { 2, 4, 3 }), Utils.CreateListNode(new List<int>() { 5, 6 })).ToString());
            //Console.WriteLine(no0002.AddTwoNumbers(Utils.CreateListNode(new List<int>() { 2, 4 }), Utils.CreateListNode(new List<int>() { 5, 6, 4 })).ToString());
            //Console.WriteLine(no0002.AddTwoNumbers(Utils.CreateListNode(new List<int>() { 2, 4, 3 }), Utils.CreateListNode(new List<int>() { })).ToString());
            //Console.WriteLine(no0002.AddTwoNumbers(Utils.CreateListNode(new List<int>() { }), Utils.CreateListNode(new List<int>() { 5, 6, 4 })).ToString());
            //Console.WriteLine(no0002.AddTwoNumbers(Utils.CreateListNode(new List<int>() { }), Utils.CreateListNode(new List<int>() { })));
            //Console.WriteLine(no0002.AddTwoNumbers(Utils.CreateListNode(new List<int>() { 5}), Utils.CreateListNode(new List<int>() { 5})).ToString());
            #endregion

            #region No0003
            //No0003 no0003 = new No0003();
            //Console.WriteLine(no0003.LengthOfLongestSubstring(""));
            //Console.WriteLine(no0003.LengthOfLongestSubstring("abcabcbb"));
            //Console.WriteLine(no0003.LengthOfLongestSubstring("bbbbb"));
            //Console.WriteLine(no0003.LengthOfLongestSubstring("pwwkew"));
            #endregion

            #region No0005
            //No0005 no0005 = new No0005();
            //Console.WriteLine(no0005.LongestPalindrome(""));
            //Console.WriteLine(no0005.LongestPalindrome("a"));
            //Console.WriteLine(no0005.LongestPalindrome("aa"));
            //Console.WriteLine(no0005.LongestPalindrome("ab"));
            //Console.WriteLine(no0005.LongestPalindrome("babad"));
            //Console.WriteLine(no0005.LongestPalindrome("cbbd"));
            #endregion

            #region No0011
            //No0011 no0011 = new No0011();
            //Console.WriteLine(no0011.MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }) == 49);
            #endregion

            #region No0015
            //No0015 no0015 = new No0015();
            //Console.WriteLine(no0015.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 }).ToConsoleString<IList<int>>());
            //Console.WriteLine(no0015.ThreeSum(new int[] { }).ToConsoleString<IList<int>>());
            //Console.WriteLine(no0015.ThreeSum(new int[] { -1, 0 }).ToConsoleString<IList<int>>());
            //Console.WriteLine(no0015.ThreeSum(new int[] { -1, 0, 1 }).ToConsoleString<IList<int>>());
            #endregion

            #region No0016
            //No0016 no0016 = new No0016();
            //Console.WriteLine(no0016.ThreeSumClosest(new int[] { -1, 2, 1, -4 }, 1));
            //Console.WriteLine(no0016.ThreeSumClosest(new int[] { -1, 2, 1, -4 }, 0));
            //Console.WriteLine(no0016.ThreeSumClosest(new int[] { -1, 2, 1, -4 }, 2));
            //Console.WriteLine(no0016.ThreeSumClosest(new int[] { -1, 2, 1, -4 }, 10));
            //Console.WriteLine(no0016.ThreeSumClosest(new int[] { -1, 2, 1, -4 }, -10));
            //Console.WriteLine(no0016.ThreeSumClosest(new int[] { 0, 0, 0 }, 1));
            #endregion

            #region No0018
            //No0018 no0018 = new No0018();
            //Console.WriteLine(no0018.FourSum(new int[] { 1, 0, -1, 0, -2, 2 }, 0).ToConsoleString<IList<int>>());
            //Console.WriteLine(no0018.FourSum(new int[] { 1, 0, -1, 0, -2, 2 }, 1).ToConsoleString<IList<int>>());
            //Console.WriteLine(no0018.FourSum(new int[] { 1, 0, -1, 0, -2, 2 }, 2).ToConsoleString<IList<int>>());
            //Console.WriteLine(no0018.FourSum(new int[] { }, 0).ToConsoleString<IList<int>>());
            //Console.WriteLine(no0018.FourSum(new int[] { -1, 0, 1 }, 0).ToConsoleString<IList<int>>());
            //Console.WriteLine(no0018.FourSum(new int[] { -2, 0, 1, 1 }, 0).ToConsoleString<IList<int>>());
            //Console.WriteLine(no0018.FourSum(new int[] { 0, 0, 0, 0 }, 0).ToConsoleString<IList<int>>());
            //Console.WriteLine(no0018.FourSum(new int[] { 1, -2, -5, -4, -3, 3, 3, 5 }, -11).ToConsoleString<IList<int>>());
            #endregion

            #region No0038
            //No0038 no0038 = new No0038();
            //Console.WriteLine(no0038.CountAndSay(1));
            //Console.WriteLine(no0038.CountAndSay(4));
            //Console.WriteLine(no0038.CountAndSay(30));
            #endregion

            #region No0049
            //No0049 no0049 = new No0049();
            //Console.WriteLine(no0049.GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" }).ToConsoleString());
            #endregion

            #region No0107
            //No0107 no0107 = new No0107();
            //TreeNode treeNode1 = Utils.CreateTreeNode(new List<string>() { "3", "9", "20", "null", "null", "15", "7" });
            //Console.WriteLine(no0107.LevelOrderBottom(treeNode1).ToConsoleString());
            //TreeNode treeNode2 = Utils.CreateTreeNode(new List<string>() { "1" });
            //Console.WriteLine(no0107.LevelOrderBottom(treeNode2).ToConsoleString());
            //TreeNode treeNode3 = Utils.CreateTreeNode(new List<string>() { });
            //Console.WriteLine(no0107.LevelOrderBottom(treeNode3).ToConsoleString());
            #endregion

            #region No0189
            //No0189 no0189 = new No0189();
            //int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            //no0189.Rotate(arr1, 3);
            //Console.WriteLine(arr1.ToConsoleString<int>());

            //int[] arr2 = new int[] { -1, -100, 3, 99 };
            //no0189.Rotate(arr2, 2);
            //Console.WriteLine(arr2.ToConsoleString<int>());
            #endregion

            #region No0338
            //No0338 no0388 = new No0338();
            //Console.WriteLine(no0388.CountBits(2).ToConsoleString());
            //Console.WriteLine(no0388.CountBits(5).ToConsoleString());
            #endregion

            #region No0371
            //No0371 no0371 = new No0371();
            //Console.WriteLine(no0371.GetSum(1, 2));
            //Console.WriteLine(no0371.GetSum(2, 3));
            #endregion

            #region No0443
            //No0443 no0443 = new No0443();
            //Console.WriteLine(no0443.Compress(new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' }));
            //Console.WriteLine(no0443.Compress(new char[] { 'a' }));
            //Console.WriteLine(no0443.Compress(new char[] { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' }));
            //Console.WriteLine(no0443.Compress(new char[] { 'a', 'a', 'a', 'b', 'b', 'a', 'a' }));
            #endregion
        }
    }
}