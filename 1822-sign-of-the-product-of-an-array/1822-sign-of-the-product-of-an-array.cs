public class Solution {
    public int ArraySign(int[] nums) {
        int p = 1;
        foreach(var i in nums){
            if(i == 0) return 0;
            if(i < 0 ) p = p * -1;
        }
        return p;
    }
}