namespace Dsa;

// https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/description/
public static class TwoSumII167
{
    // Time complexity: O(n) -> will iterate over the elements only once
    // Space complexity: O(1) -> no extra space is used
    public static int[] TwoSum(int[] numbers, int target)
    {
        var left = 0;
        var right = numbers.Length - 1;

        while (true)
        {
            var sum = numbers[left] + numbers[right];

            if (sum == target)
                return [left + 1, right + 1];

            if (sum > target)
            {
                right--;
                continue;
            }

            if (sum < target)
            {
                left++;
                continue;
            }
        }
    }
}