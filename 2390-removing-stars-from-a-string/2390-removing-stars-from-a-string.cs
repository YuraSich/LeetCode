public class Solution {
    public string RemoveStars(string s) {
        var rez = new StringBuilder();
        for (int i = 0; i< s.Length; i++)
        {
            rez.Append(s[i]);
            if (s[i] == '*')
            {
                rez.Remove(rez.Length-2, 2);
            }
        }
        return rez.ToString();
    }
}