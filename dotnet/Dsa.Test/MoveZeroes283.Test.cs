namespace Dsa.Test;

public class MoveZeroes283Test
{
    [Theory]
    [InlineData(new int[] { 0, 1, 0, 3, 12 }, new int[] { 1, 3, 12, 0, 0 })]
    [InlineData(new int[] { 0 }, new int[] { 0 })]
    public void Should_move_zeroes_to_the_left(int[] nums, int[] expectedResult)
    {
        MoveZeroes283.MoveZeroes(nums);

        Assert.Equal(expectedResult, nums);
    }
}