public class Solution {
    public int[] RearrangeArray(int[] nums)
    {
        var rez = new int[nums.Length];
        using var p = nums.Where(x => x > 0).GetEnumerator();
        using var n = nums.Where(x => x < 0).GetEnumerator();
        var i = 0;
        while (p.MoveNext() & n.MoveNext())
        {
            rez[i++] = p.Current;
            rez[i++] = n.Current;
        }

        return rez;
    }
}