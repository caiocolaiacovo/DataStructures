namespace Dsa;

// https://leetcode.com/problems/palindromic-substrings/description/?envType=problem-list-v2&envId=two-pointers
public class PalindromicSubstrings647
{
    // Time complexity:
    //      external loop: n -> will iterate over the elements only once
    //      odd while loop: n -> will expand the palindrome from the center to the left and right
    //      even while loop: n -> same as above
    //      total: n * (n + n) == n * 2n == n * n == n^2 -> O(n^2)
    // Space complexity: O(1) -> no extra space is used
    public static int CountSubstrings(string s)
    {
        var count = 0;

        for (int i = 0; i < s.Length; i++)
        {
            // odd
            var left = i;
            var right = i;

            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                count++;
                left--;
                right++;
            }

            // even
            left = i;
            right = i + 1;

            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                count++;
                left--;
                right++;
            }
        }

        return count;
    }
}