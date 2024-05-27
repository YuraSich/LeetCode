public class Solution {
    public int SpecialArray(int[] nums) {
        Array.Sort(nums);
        Array.Reverse(nums);
        var x = nums.TakeWhile((num, i) => num > i).Count();
        return nums.ElementAtOrDefault(x) == x ? -1 : x;
    }
}