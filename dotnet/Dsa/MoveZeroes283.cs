namespace Dsa;

// https://leetcode.com/problems/move-zeroes/
public class MoveZeroes283
{
    // Time complexity: O(n) - traverse the array once
    // Space complexity: O(1) - don't use any extra space
    public static void MoveZeroes(int[] nums)
    {
        var moveIdx = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0) //nothing to do, move forward
            {
                continue;
            }

            nums[moveIdx] = nums[i];
            nums[i] = 0;
            moveIdx++;
        }
    }
}