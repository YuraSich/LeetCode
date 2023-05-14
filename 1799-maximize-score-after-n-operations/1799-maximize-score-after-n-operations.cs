public class Solution {
    public int MaxScore(int[] nums) {
        int maxStates = 1 << nums.Length; // 2^(nums array size)
        int finalMask = maxStates - 1;

        // 'dp[i]' stores max score we can get after picking remaining numbers represented by 'i'.
        int[] dp = new int[maxStates];

        // Iterate on all possible states one-by-one.
        for (int state = finalMask; state >= 0; state--) {
            // If we have picked all numbers, we know we can't get more score as no number is remaining.
            if (state == finalMask) {
                dp[state] = 0;
                continue;
            }

            int numbersTaken = CountBits(state);
            int pairsFormed = numbersTaken / 2;
            // States representing even numbers are taken are only valid.
            if (numbersTaken % 2 != 0) {
                continue;
            }

            // We have picked 'pairsFormed' pairs, we try all combinations of one more pair now.
            // We iterate on two numbers using two nested for loops.
            for (int firstIndex = 0; firstIndex < nums.Length; firstIndex++) {
                for (int secondIndex = firstIndex + 1; secondIndex < nums.Length; secondIndex++) {
                    // We only choose those numbers which were not already picked.
                    if (((state >> firstIndex) & 1) == 1 || ((state >> secondIndex) & 1) == 1) {
                        continue;
                    }
                    int currentScore = (pairsFormed + 1) * Gcd(nums[firstIndex], nums[secondIndex]);
                    int stateAfterPickingCurrPair = state | (1 << firstIndex) | (1 << secondIndex);
                    int remainingScore = dp[stateAfterPickingCurrPair];
                    dp[state] = Math.Max(dp[state], currentScore + remainingScore);
                }
            }
        }

        // Returning score we get from 'n' remaining numbers of array.
        return dp[0];
    }

    // Helper method to calculate GCD using Euclidean algorithm.
    private int Gcd(int a, int b) {
        if (b == 0) {
            return a;
        }
        return Gcd(b, a % b);
    }

    // Helper method to count the number of set bits in an integer.
    private int CountBits(int n) {
        int count = 0;
        while (n > 0) {
            count += n & 1;
            n >>= 1;
        }
        return count;
    }
}
