public class Solution {
    public void SortColors(int[] nums) 
    {
        var count = new int[] { 0, 0, 0 };
        foreach (var num in nums)
        {
            count[num]++;
        }

        for (var i = 0; i < 3; i++)
        {
            var p = count.Take(i).Sum();
            for (var j = p; j < p + count[i]; j++)
            {
                nums[j] = i;
            }
        }
    }
}