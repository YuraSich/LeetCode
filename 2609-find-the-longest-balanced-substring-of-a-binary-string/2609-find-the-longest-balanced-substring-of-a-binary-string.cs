public class Solution {
    public int FindTheLongestBalancedSubstring(string s) {
    
            if (string.IsNullOrWhiteSpace(s)) return 0;
            var max_l = 0;
            var zeros = 0;
            var ones = 0;
            foreach (var i in s)
            {
                if (i == '1')
                {
                    ones++;
                    if (ones >= zeros)
                    {
                        if (ones == zeros)
                        {
                            max_l = max_l > ones * 2 ? max_l : ones * 2;
                        }
                        ones = zeros = 0;
                    }
                }
                else if (i == '0')
                {
                    if(ones > 0)
                    {
                        max_l = max_l > ones * 2 ? max_l : ones * 2;
                        ones = zeros = 0;
                    }
                    zeros++;
                }
            }
            if (ones > 0 && zeros > 0)
            {
                max_l = max_l > ones*2 ? max_l : ones * 2;
            }
            return max_l;
    }
}