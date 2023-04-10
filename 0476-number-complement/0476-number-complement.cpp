class Solution {
public:
    int findComplement(int num) {
        long i = 1;
        while (i <= num) { i *= 2; }
        return ~num & (i - 1);
    }
};