public class Solution {
    public bool Exist(char[][] board, string word) {
        int m = board.Length, n = board[0].Length;

        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                if (Dfs(i, j, 0))
                    return true;
        return false;

        bool Dfs(int i, int j, int start) {
            if (start == word.Length)
                return true;
            if (i < 0 || i >= m || j < 0 || j >= n || board[i][j] != word[start])
                return false;

            char c = board[i][j];
            board[i][j] = '~';
            bool result = Dfs(i + 1, j, start + 1) || Dfs(i - 1, j, start + 1) 
                       || Dfs(i, j + 1, start + 1) || Dfs(i, j - 1, start + 1);
            board[i][j] = c;
            return result;
        }
    }
}