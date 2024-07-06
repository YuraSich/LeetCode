public class Solution {
    public int PassThePillow(int n, int time) {
        var loops = time / (n - 1);
        var mod = time % (n - 1);
        if (loops % 2 == 0)
            return mod + 1;
        return n - mod;
    }
}