public class Solution {
    public int LongestPalindromeSubseq(string s) {
        int n = s.Length;
        int[] dp = new int[n];
        int[] dpPrev = new int[n];

        for (int i = n - 1; i >= 0; --i) {
            dp[i] = 1;
            for (int j = i + 1; j < n; ++j) {
                if (s[i] == s[j]) {
                    dp[j] = dpPrev[j - 1] + 2;
                } else {
                    dp[j] = Math.Max(dpPrev[j], dp[j - 1]);
                }
            }
            dpPrev = (int[])dp.Clone();
        }

        return dp[n - 1];
    }
}