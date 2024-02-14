public class Solution {
    public int[] RearrangeArray(int[] nums)
    {
        var rez = new List<int>(nums.Length);
        using var p = nums.Where(x => x > 0).GetEnumerator();
        using var n = nums.Where(x => x < 0).GetEnumerator();
        while (p.MoveNext() & n.MoveNext())
        {
            rez.Add(p.Current);
            rez.Add(n.Current);
        }

        return rez.ToArray();
    }
}