public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var r = "";
        for (int i = 0; i < Math.Max(word1.Length, word2.Length); i++)
        {
            r += i < word1.Length ? word1[i] : "";
            r += i < word2.Length ? word2[i] : "";
        }
        return r;
    }
}