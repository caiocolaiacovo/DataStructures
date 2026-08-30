namespace Dsa;

// https://leetcode.com/problems/subarray-sum-equals-k/description/
public class SubarraySumEqualsK560
{
    // Time complexity: O(n) -> we will iterate over the elements only once
    // Space complexity: O(n) -> we will store the prefix sums in a dictionary
    public static int SubarraySum(int[] nums, int k)
    {
        var prefixSums = new Dictionary<int, int>
        {
            {0, 1}
        };
        var counts = 0;
        var prefixSum = 0;

        foreach (var num in nums)
        {
            prefixSum += num;
            prefixSums.TryGetValue(prefixSum - k, out var value);
            counts += value;
            prefixSums[prefixSum] = prefixSums.GetValueOrDefault(prefixSum) + 1;
        }
        return counts;
    }
}