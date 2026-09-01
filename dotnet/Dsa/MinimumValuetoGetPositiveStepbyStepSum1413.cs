namespace Dsa;

// https://leetcode.com/problems/minimum-value-to-get-positive-step-by-step-sum/
public class MinimumValuetoGetPositiveStepbyStepSum1413
{
    public static int MinStartValue(int[] nums)
    {
        var sum = 0;
        var initialValue = 0;

        foreach (var n in nums)
        {
            sum += n;
            if (sum <= 0)
            {
                initialValue += (sum * -1) + 1;
                sum = 1;
            }
        }
        return initialValue == 0 ? 1 : initialValue;
    }
}