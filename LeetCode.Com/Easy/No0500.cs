using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [500]  Keyboard Row
    /// </summary>
    public class No0500
    {
        public string[] FindWords(string[] words)
        {
            string match = "";
            for (int i = 0; i < words.Length; i++)
            {
                if (Matching(words[i]))
                {
                    if (match != "")
                    {
                        match += ",";
                    }
                    match += words[i];
                }
            }
            string[] matchArr;
            if (match == "")
            {
                matchArr = new string[] { };
            }
            else
            {
                matchArr = match.Split(',');
            }

            return matchArr;
        }

        private bool Matching(string str)
        {
            string[] filter11 = new string[] { "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P" };
            string[] filter12 = new string[] { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p" };
            string[] filter21 = new string[] { "A", "S", "D", "F", "G", "H", "J", "K", "L" };
            string[] filter22 = new string[] { "a", "s", "d", "f", "g", "h", "j", "k", "l" };
            string[] filter31 = new string[] { "Z", "X", "C", "V", "B", "N", "M" };
            string[] filter32 = new string[] { "z", "x", "c", "v", "b", "n", "m" };

            string temp = str;

            //11
            string temp1 = temp;
            for (int i = 0; i < filter11.Length; i++)
            {
                temp1 = temp1.Replace(filter11[i], "");
            }
            //12
            for (int i = 0; i < filter12.Length; i++)
            {
                temp1 = temp1.Replace(filter12[i], "");
            }
            if (temp1 == "")
            {
                return true;
            }

            //21
            string temp2 = temp;
            for (int i = 0; i < filter21.Length; i++)
            {
                temp2 = temp2.Replace(filter21[i], "");
            }
            //22
            for (int i = 0; i < filter22.Length; i++)
            {
                temp2 = temp2.Replace(filter22[i], "");
            }
            if (temp2 == "")
            {
                return true;
            }

            //31
            string temp3 = temp;
            for (int i = 0; i < filter31.Length; i++)
            {
                temp3 = temp3.Replace(filter31[i], "");
            }
            //32
            for (int i = 0; i < filter32.Length; i++)
            {
                temp3 = temp3.Replace(filter32[i], "");
            }
            if (temp3 == "")
            {
                return true;
            }

            return false;
        }
    }
}
