public class Solution {
    public int FirstUniqChar(string s) {
        var good = new HashSet<char>();
        var bad = new HashSet<char>();
        foreach (var x in s.Where(x => !bad.Contains(x)))
        {
            if (!good.Add(x))
            {
                good.Remove(x);
                bad.Add(x);
            }
        }

        return good.Count != 0 ? good.Min(s.IndexOf) : -1;
    }
}