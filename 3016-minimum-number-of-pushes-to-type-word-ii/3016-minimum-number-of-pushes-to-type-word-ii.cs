public class Solution {
    public int MinimumPushes(string word) {
               const int NumberOfLetters = 26;
        const int Keys = 8;

        var freq = new int[NumberOfLetters];

        foreach (var c in word)
        {
            freq[c - 'a']++;
        }

        Array.Sort(freq, (a, b) => b - a);

        var result = 0;

        for (var i = 0; i < NumberOfLetters; i++)
        {
            result += freq[i] * (i / Keys + 1);
        }

        return result;
    }
}