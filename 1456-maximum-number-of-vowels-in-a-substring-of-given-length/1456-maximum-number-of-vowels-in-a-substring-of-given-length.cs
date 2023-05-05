public class Solution {
    public int MaxVowels(string s, int k) {
        var vowels = new HashSet<char> {'a', 'e', 'i', 'o', 'u'};
        
        // Build the window of size k, count the number of vowels it contains.
        var count = s.Take(k).Count(c => vowels.Contains(c));
        var answer = count;
        
        // Slide the window to the right, focus on the added character and the
        // removed character and update "count". Record the largest "count".
        for (var i = k; i < s.Length; i++) {
            count += vowels.Contains(s[i]) ? 1 : 0;
            count -= vowels.Contains(s[i - k]) ? 1 : 0;
            answer = Math.Max(answer, count);
        }
        
        return answer;
    }
}