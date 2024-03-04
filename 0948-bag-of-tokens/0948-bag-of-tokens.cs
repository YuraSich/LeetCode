public class Solution {
    public int BagOfTokensScore(int[] tokens, int power) {
        Array.Sort(tokens);
        int maxScore = 0, currentScore = 0;
        int left = 0, right = tokens.Length - 1;

        while (left <= right) {
            if (power >= tokens[left]) {
                power -= tokens[left++];
                currentScore++;
                maxScore = Math.Max(maxScore, currentScore);
            }
            else if (currentScore > 0) {
                power += tokens[right--];
                currentScore--;
            }
            else {
                break;
            }
        }

        return maxScore;
    }
}