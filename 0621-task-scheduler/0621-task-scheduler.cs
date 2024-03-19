public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        var counts = new int[26];
        var max = 0;
        
        foreach (var c in tasks)
        {
            var i = c - 'A';
            if (++counts[i] > max) max = counts[i];
        }
        
        var tops = 0;
        for (var i = 0; i < 26; i++)
            if (counts[i] == max) tops++;
        
        return tops + Math.Max((max - 1) * (n + 1), tasks.Length - tops);
    }
}