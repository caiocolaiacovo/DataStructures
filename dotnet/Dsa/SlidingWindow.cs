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

    // Time complexity: O(n)
    //      number of subarrays: n - k
    //      initial setup: k
    //      steps per subarray: 2
    //      O(k + ((n - k) * 2)) -> O(k + (n - k)) -> O(n)
    // Space complexity: O(1)
    public static int MaxSubarrayProductSizeK(int[] nums, int k)
    {
        var currentProduct = nums.Take(k).Aggregate(1, (x, y) => x * y);
        var maxProduct = currentProduct;

        for(int i = 0; i < nums.Length - k; i++)
        {
            currentProduct /= nums[i];
            currentProduct *= nums[i + k];
            if(currentProduct > maxProduct)
            {
                maxProduct = currentProduct;
            }
        }
        return maxProduct;
    }

    // Time complexity: O(n)
    //      first window setup = O(k)
    //      number of subarrays = n - k
    //      work per subarray = 2 (leading and trailing elements)
    //      O(k + (n - k) * 2) -> O(k + (n - k)) -> O(n)
    // Space complexity: O(1)
    public static int SubarrayTargetSumSizeK(int[] nums, int target, int k)
    {
        var sum = nums.Take(k).Sum();
        var count = sum == target ? 1 : 0;

        for(int i = 0; i < nums.Length - k; i++)
        {
            sum -= nums[i];
            sum += nums[i + k];
            if (sum == target)
            {
                count++;
            }
        }

        return count;
    }

    // Time complexity: O(n * k)
    //      anagram length = k
    //      string length = n
    //      number of subarrays = n - k
    //      O((n - k) * k) (second k is the comparision between sets) -> O(n * k - k * k) -> O(n * k) (n*k is bigger than k^2, so drop k^2)
    // Space complexity: O(2 * k) -> O(k)
    public static bool HasSubstringAnagram(string s, string anagram)
    {
        var k = anagram.Length;
        var anagramSet = new HashSet<char>(anagram[..]);
        var windowSet = new HashSet<char>(s[..k]);
        
        if (windowSet.SetEquals(anagramSet))
        {
            return true;
        }

        for(int i = 0; i < s.Length - k; i++)
        {
            windowSet.Remove(s[i]);
            windowSet.Add(s[i + k]);
            if (windowSet.SetEquals(anagramSet))
            {
                return true;
            }
        }

        return false;
    }

    // Time complexity: O(n * k)
    //      anagram size = k
    //      number of subarrays = n - k
    //      number of operations per subarray = 2
    //      initial setup = k
    //      maps comparision = k
    //      O(k * (n - k) + k + 2) -> O(k * (n - k) + k) -> O(nk - k^2 + k) -> O(n * k)
    // Space complexity: O(k + k) -> O(k)
    public static int CountSubstringAnagrams(string s, string anagram)
    {
        var k = anagram.Length;
        var anagramHash = new Dictionary<char, int>();
        var windowHash = new Dictionary<char, int>();

        for(int i = 0; i < k; i++)
        {
            anagramHash.TryGetValue(anagram[i], out var valueAnagram);
            anagramHash[anagram[i]] = valueAnagram + 1;
            windowHash.TryGetValue(s[i], out var valueWindow);
            windowHash[s[i]] = valueWindow + 1;
        }

        var count = anagramHash.Count == windowHash.Count && !anagramHash.Except(windowHash).Any() ? 1 : 0;

        for(int i = 0; i < s.Length - k; i++)
        {
            var trailingChar = s[i];
            windowHash.TryGetValue(trailingChar, out var valueToRemove);
            if (valueToRemove == 1)
            {
                windowHash.Remove(trailingChar);
            }
            else
            {
                windowHash[trailingChar] = valueToRemove - 1;
            }
            var leadingChar = s[i + k];
            windowHash.TryGetValue(leadingChar, out var value);
            windowHash[leadingChar] = value + 1;

            if(anagramHash.Count == windowHash.Count && !anagramHash.Except(windowHash).Any())
            {
                count++;
            }
        }

        return count;
    }
}