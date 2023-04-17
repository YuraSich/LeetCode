public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int n = candies.Length;
        bool[] rezult = new bool[n];
        int max = candies.Max();
        for (int i = 0; i < rezult.Length; i++)
        {
            rezult[i] = candies[i] + extraCandies >= max;
        }
        return rezult;
    }
}