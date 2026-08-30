namespace Dsa.Test;

public class SubarraySumEqualsK560Test
{
    [Theory]
    [InlineData(new int[] { 1, 1, 1 }, 2, 2)]
    [InlineData(new int[] { 1, 2, 3 }, 3, 2)]
    [InlineData(new int[] { -1, 4, -1, 2, 0, 3 }, 3, 4)]
    public void TestSubarraySum(int[] nums, int k, int expected)
    {
        var result = SubarraySumEqualsK560.SubarraySum(nums, k);
        Assert.Equal(expected, result);
    }
}