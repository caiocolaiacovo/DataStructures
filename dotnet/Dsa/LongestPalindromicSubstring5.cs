namespace Dsa;

public class LongestPalindromicSubstring5
{
    // Time complexity:
    //      external loop: O(n) -> will iterate over the elements only once
    //      odd while loop: O(n) -> will expand the palindrome from the center to the left and right
    //      even while loop: O(n) -> same as above
    //      total: O(n) * O(n + n) -> O(n) * O(2n) -> O(n^2)
    // Space complexity: O(1) -> no extra space is used
    public static string LongestPalindrome(string s)
    {
        var longestStartIdx = 0;
        var longestLength = 0;

        for (int i = 0; i < s.Length; i++)
        {
            var left = i;
            var right = i;

            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                if ((right - left + 1) > longestLength)
                {
                    longestStartIdx = left;
                    longestLength = right - left + 1;
                }
                left--;
                right++;
            }

            left = i;
            right = i + 1;

            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                if ((right - left + 1) > longestLength)
                {
                    longestStartIdx = left;
                    longestLength = right - left + 1;
                }
                left--;
                right++;
            }
        }

        return s.Substring(longestStartIdx, longestLength);
    }
}