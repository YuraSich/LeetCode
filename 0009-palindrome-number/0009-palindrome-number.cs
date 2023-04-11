public class Solution {
    public bool IsPalindrome(int x) {
            var q = x.ToString();
            for (int i = 0; i < q.Length; i++)
            {
                if (q[i] != q[q.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
    }
}