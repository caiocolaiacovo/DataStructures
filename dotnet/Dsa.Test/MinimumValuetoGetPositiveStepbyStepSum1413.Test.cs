namespace Dsa.Test;

public class MinimumValuetoGetPositiveStepbyStepSum1413Test
{
    [Theory]
    [InlineData(new int[] { -3, 2, -3, 4, 2 }, 5)]
    [InlineData(new int[] { 1, 2 }, 1)]
    [InlineData(new int[] { 1, -2, -3 }, 5)]
    public void TestMinStartValue(int[] nums, int expected)
    {
        var result = MinimumValuetoGetPositiveStepbyStepSum1413.MinStartValue(nums);
        Assert.Equal(expected, result);
    }
}