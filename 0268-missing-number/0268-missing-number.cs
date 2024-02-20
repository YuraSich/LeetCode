public class Solution {
    public int MissingNumber(int[] nums) {
        return ((int)((nums.Length / 2.0) * (nums.Length + 1))) - nums.Sum();
    }
}