public class Solution {
    public int SubarraysDivByK(int[] nums, int k) {
         Dictionary<int, int> remainderFrequency = new Dictionary<int, int>();
        remainderFrequency[0] = 1; 

        int prefixSum = 0;
        int count = 0;

        foreach (int num in nums) {
            prefixSum += num;
            int remainder = prefixSum % k;
            
            if (remainder < 0) {
                remainder += k;
            }

            if (remainderFrequency.ContainsKey(remainder)) {
                count += remainderFrequency[remainder];
                remainderFrequency[remainder]++;
            } else {
                remainderFrequency[remainder] = 1;
            }
        }

        return count;
    }
}