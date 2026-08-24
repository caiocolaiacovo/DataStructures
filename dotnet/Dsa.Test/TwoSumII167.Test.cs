namespace Dsa.Test;

public class TwoSumII167Test
{
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 1, 2 })]
    [InlineData(new int[] { 2, 3, 4 }, 6, new int[] { 1, 3 })]
    [InlineData(new int[] { -1, 0 }, -1, new int[] { 1, 2 })]
    public void Should_return_indices_of_two_numbers_that_add_up_to_target(int[] numbers, int target, int[] expected)
    {
        var output = new TwoSumII167().TwoSum(numbers, target);

        Assert.Equal(expected, output);
    }
}