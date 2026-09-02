namespace Dsa.Test;

public class SlidingWindowTest
{
    [Theory]
    [InlineData(new int[] { 4, 2, 1, -9, 8, 4, 3 }, 3, 15)]
    [InlineData(new int[] { 2, 1, 5, -4, 6 }, 3, 8)]
    [InlineData(new int[] { 1, 4, 1, 10, 25, 3, 1, 0, 20 }, 4, 40)]
    [InlineData(new int[] { 20, 50, 10, 60, 80, 70 }, 1, 80)]
    [InlineData(new int[] { -4, -18, -2, -5, -9 }, 2, -7)]
    public void TestMaxSubarraySumSizeK(int[] nums, int k, int expected)
    {
        var result = SlidingWindow.MaxSubarraySumSizeK(nums, k);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestMaxSubarraySumSizeKBig()
    {
        var size = 50000;
        var expected = 2000;
        var nums = new int[size];
        for (var i = 0; i < size; i++)
        {
            nums[i] = 1;
        }

        var result = SlidingWindow.MaxSubarraySumSizeK(nums, 2000);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestMaxSubarraySumSizeKHuge()
    {
        var size = 120000;
        var expected = 10000;
        var nums = new int[size];
        for (var i = 0; i < size; i++)
        {
            nums[i] = 1;
        }

        var result = SlidingWindow.MaxSubarraySumSizeK(nums, 10000);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new int[] { 4, 2, 1, -9, 8, 2, 3 }, 3, 48)]
    [InlineData(new int[] { -9, 1, -8, 2, 3, 7 }, 3, 72)]
    [InlineData(new int[] { 7, 4, -5, -7, 8, -10, -1 }, 2, 35)]
    [InlineData(new int[] { 60, 20, 10, 90, 50 }, 1, 90)]
    [InlineData(new int[] { 1, 2, 3, 4 }, 4, 24)]
    public void TestMaxSubarrayProductSizeK(int[] nums, int k, int expected)
    {
        var result = SlidingWindow.MaxSubarrayProductSizeK(nums, k);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new int[] { 2, 3, 2, 2, 3, 1, 3, 8, 5, 0, 2, 4 }, 7, 3, 5)]
    [InlineData(new int[] { 2, 3, 2 }, 7, 3, 1)]
    [InlineData(new int[] { 1, 2, 2, 2, 2, 4, 6, 5, 1, 2, 0, 10, -2, 7 }, 8, 4, 2)]
    public void TestSubarrayTargetSumSizeK(int[] nums, int target, int k, int expected)
    {
        var result = SlidingWindow.SubarrayTargetSumSizeK(nums, target, k);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("greyhounds", "hoy", true)]
    [InlineData("gruyheonds", "hoy", false)]
    [InlineData("breakdowns", "snow", true)]
    [InlineData("dermatoglyphics", "red", true)]
    [InlineData("southernly", "thorny", false)]
    [InlineData("southernly", "nerlysouth", true)]
    public void TestHasSubstringAnagram(string s, string anagram, bool expected)
    {
        var result = SlidingWindow.HasSubstringAnagram(s, anagram);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("tacoctacabcatt", "cat", 4)]
    [InlineData("qtqt", "qt", 3)]
    [InlineData("gattactat", "att", 3)]
    [InlineData("gattactat", "tag", 1)]
    [InlineData("rreeadreaerrand", "reade", 4)]
    [InlineData("versorevairlg", "serve", 0)]
    public void TestCountSubstringAnagrams(string s, string anagram, int expected)
    {
        var result = SlidingWindow.CountSubstringAnagrams(s, anagram);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 7, 5 }, 12, new int[] { 1, 3 })]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 15, new int[] { 0, 4 })]
    [InlineData(new int[] { 3, 1, 4, 9, 2, 1, 7 }, 10, new int[] { 4, 6 })]
    [InlineData(new int[] { 3, 1, 4, 9, 2, 1, 7 }, 11, new int[] { 3, 4 })]
    public void TestFindSubarraySum(int[] nums, int target, int[] expected)
    {
        var result = SlidingWindow.FindSubarraySum(nums, target);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 1, 5, 2, 3, 10, 1, 9, 4, 3, 3, 7 }, 10, 4)]
    [InlineData(new int[] { 7, 2, 4, 2, 1 }, 5, -1)]
    [InlineData(new int[] { 4, 2, 2, 2, 1, 1 }, 6, 4)]
    [InlineData(new int[] { 1, 5, 2, 4, 9, 2 }, 11, 3)]
    [InlineData(new int[] { 10, 4, 8, 4 }, 8, 1)]
    [InlineData(new int[] { 10, 4, 8, 0, 4 }, 8, 2)]
    [InlineData(new int[] { 2, 4, 1, 1, 2 }, 10, 5)]
    public void TestLongestSubarraySum(int[] nums, int target, int expected)
    {
        var result = SlidingWindow.LongestSubarraySum(nums, target);
        Assert.Equal(expected, result);
    }
}