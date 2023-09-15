using System;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Minimum Number of Moves to Seat Everyone
    /// </summary>
    public class No2037
    {
        /*
            解题思路：将椅子和学生排序，然后按顺序一一对应
         */
        public int MinMovesToSeat(int[] seats, int[] students)
        {
            Array.Sort(seats);
            Array.Sort(students);

            int steps = 0;
            for (int i = 0; i < seats.Length; i++)
            {
                steps += Math.Abs(seats[i] - students[i]);
            }

            return steps;
        }
    }
}
