namespace Dsa.Test;

public class ValidPalindrome125Test
{
    [Theory]
    [InlineData("A man, a plan, a canal: Panama", true)]
    [InlineData("race a car", false)]
    [InlineData(" ", true)]
    public void IsPalindrome_ShouldReturnExpectedResult(string s, bool expected)
    {
        var result = ValidPalindrome125.IsPalindrome(s);
        Assert.Equal(expected, result);
    }
}