public class Solution {
    public bool ValidateStackSequences(int[] pushed, int[] popped) {
        int N = pushed.Length;
        Stack<int> stack = new();

        int j = 0;
        foreach (var x in pushed)
        {
            stack.Push(x);
            while (stack.Any() && j < N && stack.Peek() == popped[j])
            {
                stack.Pop();
                j++;
            }
        }
        return j == N;
    }
}