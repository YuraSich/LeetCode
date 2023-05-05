class Solution:
    def maxVowels(self, s: str, k: int) -> int:
        vowels = set(['a', 'e', 'i', 'o', 'u'])
        max_vowels = 0
        count = 0
        start = 0
        for end in range(len(s)):
            if s[end] in vowels:
                count += 1
            if end - start == k - 1:
                max_vowels = max(max_vowels, count)
                if s[start] in vowels:
                    count -= 1
                start += 1
        return max_vowels