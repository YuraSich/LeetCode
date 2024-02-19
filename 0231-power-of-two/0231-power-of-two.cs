public class Solution {
    public bool IsPowerOfTwo(int n) {
        if(n <= 0)
        {
            return false;    
        }
        
        for (var i = n; i > 1; i /= 2)
        {
            if (i % 2 != 0)
            {
                return false;
            }
        }

        return true;
    }
}