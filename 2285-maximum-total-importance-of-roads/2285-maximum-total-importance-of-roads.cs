public class Solution {
    public long MaximumImportance(int n, int[][] roads) => roads
        .SelectMany(r => r)
        .GroupBy(c => c)
        .OrderByDescending(g => g.Count())
        .Select((g, i) => g.LongCount() * (n - i))
        .Sum();
}