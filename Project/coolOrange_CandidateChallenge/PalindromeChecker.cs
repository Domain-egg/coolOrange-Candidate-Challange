using System;
using System.Linq;

namespace coolOrange_CandidateChallenge
{
    public class PalindromeChecker
    {
        public static bool IsPalindrome(string s)
        {
            return RecPalindrome(s, 0, s.Length-1);
        }

        private static bool RecPalindrome(string s, int front, int back)
        {
            if (front > back) return true;
            if (s.ElementAt(front).Equals(s.ElementAt(back)))
            {
                return RecPalindrome(s, ++front, --back);
            }

            return false;
        }
    }
}
