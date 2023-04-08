public class Solution {
    public int FindTheLongestBalancedSubstring(string s) {
    
    if (string.IsNullOrWhiteSpace(s)) return 0;
    var max_l = 0;
    var zeros = 0;
    var ones = 0;
    var length = 0;
    foreach (var i in s)
    {
        if (i == '1')
        {
            ones++;
            if (ones >= zeros)
            {
                if (ones == zeros)
                {
                    length = ones * 2;
                    max_l = Math.Max(max_l, length);
                }
                ones = zeros = 0;
            }
        }
        else if (i == '0')
        {
            if(ones > 0)
            {
                length = ones * 2;
                max_l = Math.Max(max_l, length);
                ones = zeros = 0;
            }
            zeros++;
        }
    }
    if (ones > 0 && zeros > 0)
    {
        length = ones * 2;
        max_l = Math.Max(max_l, length);
    }
    return max_l;
}
}