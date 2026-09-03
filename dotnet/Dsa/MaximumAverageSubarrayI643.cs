namespace Dsa;

// https://leetcode.com/problems/maximum-average-subarray-i/description/
public class MaximumAverageSubarrayI643
{
    // Time complexity: O(n)
    //      number of subarray = n - k
    //      steps per window = 2
    //      initial setup = k
    //      O(2(n-k)+k) -> O(2n-2k+k) -> O(2n-k) -> O(n)
    // Space complexity: O(1)
    public static double FindMaxAverage(int[] nums, int k)
    {
        double sum = 0;
        for (int i = 0; i < k; i++)
        {
            sum += nums[i];
        }

        double max = sum / k;
        for (int i = 0; i < nums.Length - k; i++)
        {
            sum -= nums[i];
            sum += nums[i + k];

            double avg = sum / k;
            max = Math.Max(max, avg);
        }

        return max;
    }
}