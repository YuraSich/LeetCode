public class Solution {
   public long MostPoints(int[][] questions) {
    int n = questions.Length;
    long[] dp = new long[n];
    dp[n - 1] = questions[n - 1][0];

    for (int i = n - 2; i >= 0; --i) {
        dp[i] = questions[i][0];
        int skip = questions[i][1];
        if (i + skip + 1 < n) {
            dp[i] += dp[i + skip + 1];
        }

        // dp[i] = max(solve it, skip it)
        dp[i] = Math.Max(dp[i], dp[i + 1]);
    }

    return dp[0];
}

}