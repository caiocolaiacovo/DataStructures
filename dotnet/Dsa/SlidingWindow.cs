namespace Dsa;

public class SlidingWindow
{
    // Time complexity: O(n)
    //      first window setup = O(k)
    //      number of subarrays = n - k
    //      work per subarray = 2 (leading and trailing elements)
    //      O(k + (n - k) * 2) -> O(k + (n - k)) -> O(n)
    // Space complexity: O(1)
    public static int MaxSubarraySumSizeK(int[] nums, int k)
    {
        var currentSum = nums.Take(k).Sum();
        var maxSum = currentSum;
        
        for(int i = 0; i < nums.Length - k; i++)
        {
            currentSum -= nums[i];
            currentSum += nums[i + k];
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
            }
        }
        return maxSum;
    }
}