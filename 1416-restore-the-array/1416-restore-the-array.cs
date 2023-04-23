public class Solution {
    private const int mod = 1_000_000_007;

    // Number of possible splits for substring s[start ~ m-1].
    private int Dfs(int[] dp, int start, string s, int k) {
        // If we have already updated dp[start], return it.
        if (dp[start] != 0)
            return dp[start];

        // There is only 1 split for an empty string.
        if (start == s.Length)
            return 1;

        // Number can't have leading zeros.
        if (s[start] == '0')
            return 0;

        // For all possible starting number, add the number of arrays 
        // that can be printed as the remaining string to count.
        int count = 0;
        for (int end = start; end < s.Length; ++end) {
            string currNumber = s.Substring(start, end - start + 1);
            if (long.Parse(currNumber) > k)
                break;
            count = (count + Dfs(dp, end + 1, s, k)) % mod;
        }

        // Update dp[start] so we don't recalculate it later.
        dp[start] = count;
        return count;
    }
    
    public int NumberOfArrays(string s, int k) {
        int m = s.Length;
        int[] dp = new int[m + 1];
        return Dfs(dp, 0, s, k);
    }
}