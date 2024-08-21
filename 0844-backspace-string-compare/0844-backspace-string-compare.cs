public class Solution {
    public bool BackspaceCompare(string s, string t) {
        var aString = RemoveBackspaces(s);
        var bString = RemoveBackspaces(t);
        return aString == bString;
    }

    static string RemoveBackspaces(string a)
    {
        var result = new Stack<char>();
        foreach(var c in a)
        {
            if (c != '#')
            {
                result.Push(c);
            }
            else
            {
                if(result.Count > 0)
                {
                    result.Pop();
                }
            }
        }
        return new string(result.Reverse().ToArray());
    }
}