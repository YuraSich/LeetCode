public class Solution {
    public int[] GetAverages(int[] nums, int k) {
        if (k == 0)
            return nums;
        
        var avg = Enumerable.Repeat(-1, nums.Length).ToArray(); 
        var chunkSize = 2*k+1;
        if (nums.Length < chunkSize)
            return avg;
        
        long sum = nums.Take(chunkSize-1).Aggregate(0L, (sum, next) => sum+next); // declare variable of long type to prevent overflow exception
        for (int i=k; i<nums.Length-k; i++) {
            sum += nums[i+k];
            avg[i] = Convert.ToInt32(sum/chunkSize);
            sum -= nums[i-k];        
        }
        return avg;
    }
}