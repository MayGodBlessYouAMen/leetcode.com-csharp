using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [383]  Ransom Note
    /// </summary>
    public class No0383
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {

            List<char> list = magazine.ToList();
            for (int i = 0; i < ransomNote.Length; i++)
            {
                //int index = magazine.IndexOf(ransomNote[i]); 
                int index = list.IndexOf(ransomNote[i]);
                if (index == -1)
                {
                    return false;
                }
                //magazine = magazine.Remove(index,1);    =>Memory Limit Exceeded
                list.RemoveAt(index);
            }

            return true;
        }
    }
}

