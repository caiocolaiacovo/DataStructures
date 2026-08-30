namespace Dsa;

// https://leetcode.com/problems/valid-palindrome/description/?envType=problem-list-v2&envId=two-pointers
public class ValidPalindrome125
{
    // Time complexity: O(n) -> we will iterate over the elements only once
    // Space complexity: O(1) -> no extra space is used
    public static bool IsPalindrome(string s)
    {
        var left = 0;
        var right = s.Length - 1;

        while (left <= right)
        {
            if (!char.IsLetterOrDigit(s[left]))
            {
                left++;
                continue;
            }
            if (!char.IsLetterOrDigit(s[right]))
            {
                right--;
                continue;
            }
            if (char.ToLower(s[left]) != char.ToLower(s[right]))
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}