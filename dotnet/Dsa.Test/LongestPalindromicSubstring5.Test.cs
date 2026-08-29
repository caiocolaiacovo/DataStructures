namespace Dsa.Test;

public class LongestPalindromicSubstring5Test
{
    [Theory]
    [InlineData("babad", "bab")]
    [InlineData("cbbd", "bb")]
    [InlineData("a", "a")]
    [InlineData("ac", "a")]
    [InlineData("abababacc", "abababa")]
    public void TestLongestPalindrome(string input, string expected)
    {
        var result = LongestPalindromicSubstring5.LongestPalindrome(input);
        Assert.Equal(expected, result);
    }
}