public class Solution {
    public int SubsetXORSum(int[] nums) {
        return Subset(nums, 0, 0);
    }

    private int Subset(int[] nums, int i, int curr) {
        return i >= nums.Length ?
            curr :
            Subset(nums, i + 1, nums[i] ^ curr) + Subset(nums, i + 1, curr);
    }
}