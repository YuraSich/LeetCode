public class Solution {
    public int[][] GenerateMatrix(int n) {
        int[,] result = new int[n, n];
        int cnt = 1;
        int[,] dir = {{0, 1}, {1, 0}, {0, -1}, {-1, 0}};
        int d = 0;
        int row = 0;
        int col = 0;
        while (cnt <= n * n) {
            result[row, col] = cnt++;
            int r = (row + dir[d, 0] + n) % n;
            int c = (col + dir[d, 1] + n) % n;

            // change direction if next cell is non zero
            if (result[r, c] != 0) d = (d + 1) % 4;

            row += dir[d, 0];
            col += dir[d, 1];
        }
        int[][] resultArray = new int[n][];
        for (int i = 0; i < n; i++) {
            resultArray[i] = new int[n];
            for (int j = 0; j < n; j++) {
                resultArray[i][j] = result[i, j];
            }
        }
        return resultArray;
    }
}