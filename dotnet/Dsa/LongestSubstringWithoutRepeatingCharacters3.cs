namespace Dsa;

// https://leetcode.com/problems/longest-substring-without-repeating-characters/
public class LongestSubstringWithoutRepeatingCharacters3
{
    // Time complexity: O(n)
    //      end pointer = n
    //      start pointer = n
    //      O(2 * n) -> O(n)
    // Space complexity: O(k)
    public static int LengthOfLongestSubstring(string s)
    {
        var start = 0;
        var windowHash = new Dictionary<char, int>();
        var longest = 0;

        for (int end = 0; end < s.Length; end++)
        {
            if (windowHash.TryGetValue(s[end], out var value))
            {
                windowHash[s[end]] = value + 1;
            }
            else
            {
                windowHash.Add(s[end], 1);
            }

            while (windowHash[s[end]] > 1)
            {
                windowHash[s[start]] = windowHash[s[start]] - 1;
                start++;
            }

            longest = Math.Max(longest, end - start + 1);
        }

        return longest;
    }
}