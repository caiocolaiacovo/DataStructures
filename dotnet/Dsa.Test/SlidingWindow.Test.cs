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
}