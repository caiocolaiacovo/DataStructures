namespace Dsa;

// https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/description/
public class TwoSumII167
{
    public int[] TwoSum(int[] numbers, int target)
    {
        var left = 0;
        var right = numbers.Length - 1;

        while (true)
        {
            // Console.WriteLine($"left {left}");
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