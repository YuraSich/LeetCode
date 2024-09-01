public class Solution
{
    public int[][] Construct2DArray(int[] original, int m, int n)
    {
        if (original.Length != m * n)
        {
            return Array.Empty<int[]>();
        }
        var result = new int[m][];
        var index = 0;
        for (var i = 0; i < m; i++)
        {
            result[i] = new int[n];
            for (var j = 0; j < n; j++)
            {
                result[i][j] = original[index++];
            }
        }

        return result;
    }
}