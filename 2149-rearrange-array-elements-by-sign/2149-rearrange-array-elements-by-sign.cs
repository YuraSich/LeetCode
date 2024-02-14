public class Solution {
    public int[] RearrangeArray(int[] nums)
    {
        var rez = new List<int>(nums.Length);
        using var p = Positive(nums).GetEnumerator();
        using var n = Negative(nums).GetEnumerator();
        while (p.MoveNext() & n.MoveNext())
        {
            rez.Add(p.Current);
            rez.Add(n.Current);
        }

        return rez.ToArray();
    }

    private static IEnumerable<int> Positive(int[] nums)
    {
        return nums.Where(x => x > 0);
    }


    private static IEnumerable<int> Negative(int[] nums)
    {
        return nums.Where(x => x < 0);
    }
}