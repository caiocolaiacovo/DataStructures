namespace Dsa;

// https://leetcode.com/problems/range-sum-query-immutable/description/
public class RangeSumQuery303
{
    private int[] _prefixSums = [];

    public RangeSumQuery303(int[] nums)
    {
        for (int i = 1; i < nums.Length; i++)
        {
            nums[i] = nums[i - 1] + nums[i];
        }
        _prefixSums = nums;
    }

    public int SumRange(int left, int right)
    {
        if (left == 0)
        {
            return _prefixSums[right];
        }
        return _prefixSums[right] - _prefixSums[left - 1];
    }
}