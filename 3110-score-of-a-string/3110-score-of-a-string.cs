public class Solution {
    public int ScoreOfString(string s) {
        int result = 0;
        for (int i = 1; i < s.Length; i++) {
            result += Math.Abs(s[i] - s[i-1]);
        }
        return result;
    }
}