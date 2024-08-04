public class Solution {
   public int RangeSum(int[] nums, int n, int left, int right)
    {
        var sums = MakeSum(nums).ToArray();
        Array.Sort(sums);        var r = 0;
        foreach(var s in sums.Skip(left - 1).Take(right - left + 1))
        {
            r = (r + s) % 1000000007; 
        }
        return r;
    }

    private static IEnumerable<int> MakeSum(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int subsum = nums[i];
            yield return subsum;
            for (int j = i+1; j < nums.Length; j++)
            {
                yield return subsum += nums[j];
            }
        }
    }
}