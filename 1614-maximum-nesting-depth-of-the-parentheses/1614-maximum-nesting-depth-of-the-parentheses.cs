public class Solution {
    public int MaxDepth(string s) {
     int maxDepth = 0;
     int depth = 0;

     foreach (char c in s)
     {
         if (c == '(')
         {
             if (++depth > maxDepth)
             {
                 maxDepth = depth;
             }
         }
         else if (c == ')')
         {
             depth--;
         }
     }

     return maxDepth;
    }
}