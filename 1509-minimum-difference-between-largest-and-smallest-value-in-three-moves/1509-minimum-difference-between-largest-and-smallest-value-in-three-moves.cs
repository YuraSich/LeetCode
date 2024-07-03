public class Solution {
    public int MinDifference(int[] nums) {
        if (nums.Length <= 4)
            return 0;
        
        Array.Sort(nums);
        
        int[] variants = new int[] {
            nums[nums.Length - 1] - nums[3],
            nums[nums.Length - 2] - nums[2],
            nums[nums.Length - 3] - nums[1],
            nums[nums.Length - 4] - nums[0],
        };
        
        return variants.Min();
    }
}