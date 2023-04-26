public class Solution {
    public int AddDigits(int num) {
        var s = num;
        while (s >= 10) {
            s = s.ToString().Sum(c => c - '0');
        }
        return s;
    }
}