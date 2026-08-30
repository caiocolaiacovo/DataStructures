namespace Dsa.Test;

public class PalindromicSubstrings647Test
{
    [Theory]
    [InlineData("abc", 3)]
    [InlineData("aaa", 6)]
    [InlineData("a", 1)]
    [InlineData("ab", 2)]
    public void CountSubstringsTest(string s, int expected)
    {
        var actual = PalindromicSubstrings647.CountSubstrings(s);
        Assert.Equal(expected, actual);
    }
}