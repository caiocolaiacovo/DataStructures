namespace Dsa.Test;

public class LongestSubstringWithoutRepeatingCharacters3Test
{
    [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    public void TestLengthOfLongestSubstring(string s, int expected)
    {
        var result = LongestSubstringWithoutRepeatingCharacters3.LengthOfLongestSubstring(s);
        Assert.Equal(expected, result);
    }
}