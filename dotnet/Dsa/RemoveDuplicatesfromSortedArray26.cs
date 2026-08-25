namespace Dsa;

// https://leetcode.com/problems/remove-duplicates-from-sorted-array/
public static class RemoveDuplicatesfromSortedArray26
{
    // Time complexity: O(n) -> will iterate over the elements only once
    // Space complexity: O(1) -> no extra space is used
    public static int RemoveDuplicates(int[] nums)
    {
        var left = 0;
        var right = 0;

        while (right < nums.Length)
        {
            if (nums[left] == nums[right])
            {
                right++;
                continue;
            }

            if (left + 1 == right)
            {
                left = right;
                right++;
                continue;
            }

            left++;
            nums[left] = nums[right];
            right++;
        }

        return left + 1;
    }
}