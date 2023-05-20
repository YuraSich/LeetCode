public class Solution
{
    public double[] CalcEquation(IList<IList<string>> eq, double[] vals, IList<IList<string>> q)
    {
        Dictionary<string, Dictionary<string, double>> map = new();
        HashSet<string> visited = new();

        foreach (var (num, den, val) in eq.Zip(vals, (e, v) => (e[0], e[1], v)))
        {
            if (!map.ContainsKey(num)) map[num] = new();
            if (!map.ContainsKey(den)) map[den] = new();

            map[num][den] = 1 / val;
            map[den][num] = val;
        }

        return q.Select(s => FindResult(s[1], s[0])).ToArray();

        double FindResult(string s, string t)
        {
            if (!map.ContainsKey(s)) return -1;
            if (s == t) return 1;
            
            double cur = -1;
            visited.Add(s);
            
            foreach (var k in map[s].Keys)
            {
                if (visited.Contains(k)) continue;
                cur = FindResult(k, t);
                if (cur != -1)
                {
                    cur *= map[s][k];
                    break;
                }
            }

            visited.Remove(s);
            return cur;
        }
    }
}