public class Solution {
    public int MinOperations(string[] logs) {
        var depth = 0;
        foreach (var log in logs)
        {
            if (log == "../")
            {
                if (depth > 0)
                {
                    depth--;
                }
            }
            else if (log != "./")
            {
                depth++;
            }
        }

        return depth;
    }
}