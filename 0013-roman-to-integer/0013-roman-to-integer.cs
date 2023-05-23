public class Solution {
    public int RomanToInt(string s) {
       int result = 0;
            s = s.Replace("IV", "IIII").Replace("IX", "VIIII").Replace("XL", "XXXX").Replace("XC", "LXXXX").Replace("CD", "CCCC").Replace("CM", "DCCCC");
            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case 'I':result += 1;break;
                    case 'V': result += 5; break;
                    case 'X':result += 10;break;
                    case 'L': result += 50; break;
                    case 'C':result += 100;break;
                    case 'D': result += 500; break;
                    case 'M': result += 1000; break;
                }
            }
            return result;
    }
}