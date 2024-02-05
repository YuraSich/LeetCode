public class Solution {
    public int FirstUniqChar(string s) {
        var good = new HashSet<char>();
        var bad = new HashSet<char>();
         foreach (var x in s)
         {
             if (bad.Contains(x))
             {
                 continue;
             }
             if (!good.Add(x))
             {
                 good.Remove(x);
                 bad.Add(x);
             }

         }

        return good.Count != 0 ? good.Min(s.IndexOf) : -1;
    }
}