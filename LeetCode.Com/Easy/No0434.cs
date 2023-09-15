using System.Linq;

namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Number of Segments in a String
    /// </summary>
    public class No0434
    {
        public int CountSegments(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return 0;
            }
            var arr = s.Split(' ');
            return arr.Where(x => !string.IsNullOrWhiteSpace(x)).Count();
        }
    }
}
