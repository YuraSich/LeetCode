public class Solution {
    public int FirstUniqChar(string s) {
        var unique = new Dictionary<char, int>();
        foreach (var x in s)
        {
            unique.TryAdd(x, 0);
            unique[x] += 1;
        }

        KeyValuePair<char, int>? rez = unique.FirstOrDefault(x => x.Value == 1);
        return rez == null ? -1 : s.IndexOf(rez.Value.Key);
    }
}