public class Solution {
    public int MatrixScore(int[][] grid)
    {
        for (int i = 0; i < grid.Length; i++)
        {
            if (Number(grid[i]) < Number(Inverce(grid[i])))
            {
                grid[i] = Inverce(grid[i]);
            }
        }
        for (int j = 0; j < grid[0].Length; j++)
        {
            int z = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                if (grid[i][j] == 0)
                {
                    z++;
                }
            }
            if(z > grid.Length / 2)
            {
                for (int i = 0; i < grid.Length; i++)
                {
                    grid[i][j] = grid[i][j] == 0 ? 1 : 0;
                }
            }
        }

        int sum = 0;
        for(int i = 0;i < grid.Length; i++)
        {
            sum += Number(grid[i]);
        }

        return sum;
    }

    private static int Number(int[] digits)
    {
        int s = 0;
        int p = 1;
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            s += p * digits[i];
            p *= 2;
        }
        return s;
    }

    private static int[] Inverce(int[] digits) => digits.Select(x => x == 0 ? 1 : 0).ToArray();
}