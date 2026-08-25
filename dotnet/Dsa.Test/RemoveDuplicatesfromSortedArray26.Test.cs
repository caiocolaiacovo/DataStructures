namespace Dsa.Test;

public class RemoveDuplicatesfromSortedArray26Test
{
    [Theory]
    [InlineData(new int[] { 1, 1, 2 }, new int[] { 1, 2 }, 2)]
    [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, new int[] { 0, 1, 2, 3, 4 }, 5)]
    [InlineData(new int[] { 1, 2, 2, 3, 3, 3, 3, 3, 4, 4, 5, 6, 7, 7, 7, 8 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 8)]
    public void Should_remove_duplicates_from_sorted_array(int[] nums, int[] expectedNums, int expectedLength)
    {
        var outputLength = RemoveDuplicatesfromSortedArray26.RemoveDuplicates(nums);

        Assert.Equal(expectedLength, outputLength);
        for (var i = 0; i < outputLength; i++)
        {
            Assert.Equal(expectedNums[i], nums[i]);
        }
    }
}