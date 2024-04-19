public class Solution {
     public int NumIslands(char[][] grid) {
        if (grid == null || grid.Length == 0) {
            return 0;
        }
        
        int count = 0;
        int rows = grid.Length;
        int cols = grid[0].Length;
        
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (grid[i][j] == '1') {
                    BFS(grid, i, j);
                    count++;
                }
            }
        }
        
        return count;
    }

    private void BFS(char[][] grid, int row, int col) {
        int rows = grid.Length;
        int cols = grid[0].Length;
        
        Queue<(int, int)> queue = new Queue<(int, int)>();
        queue.Enqueue((row, col));
        
        while (queue.Count > 0) {
            (int r, int c) = queue.Dequeue();
            
            if (r < 0 || c < 0 || r >= rows || c >= cols || grid[r][c] == '0') {
                continue;
            }
            
            grid[r][c] = '0';
            
            // Add adjacent land cells to the queue
            queue.Enqueue((r + 1, c));
            queue.Enqueue((r - 1, c));
            queue.Enqueue((r, c + 1));
            queue.Enqueue((r, c - 1));
        }
    }
}