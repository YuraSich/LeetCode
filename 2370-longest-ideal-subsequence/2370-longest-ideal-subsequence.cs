public class Solution {
    public int LongestIdealString(string s, int k) {
         int[] dp = new int[26];
         int maxLength = 0;

         foreach (char c in s)
         {
             int charIndex = c - 'a';
             int maxLocalLength = dp[charIndex];

             int lowerBound = Math.Max(0, charIndex - k);
             int upperBound = Math.Min(25, charIndex + k);

             // Check within the range
             for (int i = lowerBound; i <= upperBound; i++)
             {
                 maxLocalLength = Math.Max(maxLocalLength, dp[i]);
             }

             dp[charIndex] = maxLocalLength + 1;

             maxLength = Math.Max(maxLength, dp[charIndex]);
         }

         return maxLength;
    }
}