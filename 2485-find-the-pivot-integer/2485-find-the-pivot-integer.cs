public class Solution {
    public int PivotInteger(int n) {
        var t = Math.Sqrt(n * (n + 1) / 2); 
        int r = (int)t;
        return t == r ? r : -1;
    }
}