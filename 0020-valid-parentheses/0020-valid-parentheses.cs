public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new();
        foreach (char c in s)
        {
            if (c == '(' || c == '[' || c == '{') { stack.Push(c); }
            if (c == ')') { if (stack.Count == 0 || stack.Pop() != '(') { return false; } }
            if (c == ']') { if (stack.Count == 0 || stack.Pop() != '[') { return false; } }
            if (c == '}') { if (stack.Count == 0 || stack.Pop() != '{') { return false; } }
        }
        if (stack.Count != 0) { return false; }
        return true;
    }
}