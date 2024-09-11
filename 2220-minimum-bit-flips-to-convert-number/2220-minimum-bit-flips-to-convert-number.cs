public class Solution 
{
    public int MinBitFlips(int start, int goal) 
    {
         var s = start ^ goal;

        var count = 0;
        while (s > 0)
        {
            count += s % 2;
            s /= 2;
        }
        return count;
    }
}