namespace Dsa.Test;

public class RangeSumQuery303Test
{
    [Fact]
    public void Should_return_sum_range()
    {
        RangeSumQuery303 numArray = new RangeSumQuery303(new int[] { -2, 0, 3, -5, 2, -1 });

        var result1 = numArray.SumRange(0, 2);
        var result2 = numArray.SumRange(2, 5);
        var result3 = numArray.SumRange(0, 5);

        Assert.Equal(1, result1);
        Assert.Equal(-1, result2);
        Assert.Equal(-3, result3);
    }
}