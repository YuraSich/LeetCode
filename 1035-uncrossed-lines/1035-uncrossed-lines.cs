using System;

public class Solution {
    private int Solve(int i, int j, int[] nums1, int[] nums2, int[][] memo) {
        if (i <= 0 || j <= 0) {
            return 0;
        }

        if (memo[i][j] != -1) {
            return memo[i][j];
        }

        if (nums1[i - 1] == nums2[j - 1]) {
            memo[i][j] = 1 + Solve(i - 1, j - 1, nums1, nums2, memo);
        } else {
            memo[i][j] =
                Math.Max(Solve(i, j - 1, nums1, nums2, memo), Solve(i - 1, j, nums1, nums2, memo));
        }
        return memo[i][j];
    }

    public int MaxUncrossedLines(int[] nums1, int[] nums2) {
        int n1 = nums1.Length;
        int n2 = nums2.Length;

        int[][] memo = new int[n1 + 1][];
        for (int i = 0; i < memo.Length; i++) {
            memo[i] = new int[n2 + 1];
            for (int j = 0; j < memo[i].Length; j++) {
                memo[i][j] = -1;
            }
        }

        return Solve(n1, n2, nums1, nums2, memo);
    }
}
