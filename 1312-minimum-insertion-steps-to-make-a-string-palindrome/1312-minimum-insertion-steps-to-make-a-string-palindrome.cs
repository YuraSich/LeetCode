public class Solution {
    private int lcs(string s1, string s2, int m, int n) {
        int[] dp = new int[n + 1];
        int[] dpPrev = new int[n + 1];

        for (int i = 0; i <= m; i++) {
            for (int j = 0; j <= n; j++) {
                if (i == 0 || j == 0) {
                    // One of the two strings is empty.
                    dp[j] = 0;
                } else if (s1[i - 1] == s2[j - 1]) {
                    dp[j] = 1 + dpPrev[j - 1];
                } else {
                    dp[j] = Math.Max(dpPrev[j], dp[j - 1]);
                }
            }
            dpPrev = (int[])dp.Clone();
        }

        return dp[n];
    }

    public int MinInsertions(string s) {
        int n = s.Length;
        string sReverse = new string(s.Reverse().ToArray());

        return n - lcs(s, sReverse, n, n);
    }
}