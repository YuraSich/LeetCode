public class Solution {
    public int RangeBitwiseAnd(int left, int right) {
        var count = 0;

         while (left != right)
         {
             count++;
             left /= 2;
             right /= 2;
         }

         return left << count;
    }
}