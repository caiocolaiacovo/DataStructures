namespace Dsa.Test;

public class MaximumAverageSubarrayI643Test
{
    [Theory]
    [InlineData(new int[] { 1, 12, -5, -6, 50, 3 }, 4, 12.75)]
    [InlineData(new int[] { 5 }, 1, 5.00)]
    public void TestFindMaxAverage(int[] nums, int k, double expected)
    {
        var result = MaximumAverageSubarrayI643.FindMaxAverage(nums, k);
        Assert.Equal(expected, result);
    }
}