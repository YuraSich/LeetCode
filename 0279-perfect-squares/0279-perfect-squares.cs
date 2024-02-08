public class Solution {
    public int NumSquares(int x) {
        // x = a^2
        if (IsSquare(x))
        {
            return 1;
        }

        // x = 4^k*(8*m + 7) => 4
        for (int k = 0; k <= Math.Pow(x, 1 / 4f); k++)
        {
            for (int m = 0; m < x; m++)
            {
                double r = Math.Pow(4, k) * (8 * m + 7);
                if (r > x) continue;
                if (r == x)
                {
                    return 4;
                }
            }
        }

        // x - i^2 = a^2 => 2
        for (int i = 0; i < Math.Sqrt(x); i++)
        {
            if(IsSquare(x - (i * i))) return 2;
        }


        return 3;
    }

    private static bool IsSquare(int x)
    {
        int y = (int)Math.Sqrt(x);
        return y * y == x;
    }
}
