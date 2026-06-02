namespace Dsa.Test;

public class CodilityCountriesCountTest
{
    [Fact]
    public void Should_pass()
    {
        var A = new int[][]
        {
            new int[] { 5, 4, 4 },
            new int[] { 4, 3, 4 },
            new int[] { 3, 2, 4 },
            new int[] { 2, 2, 2 },
            new int[] { 3, 3, 4 },
            new int[] { 1, 4, 4 },
            new int[] { 4, 1, 1 },
        };

        var result = CodilityCountriesCount.Count(A);

        Assert.Equal(11, result);
    }
}