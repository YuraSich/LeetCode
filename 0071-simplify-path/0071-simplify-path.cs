public class Solution {
    public string SimplifyPath(string path) {
 List<string> folders = path.Split('/').Where(x => !string.IsNullOrEmpty(x) && x != ".").Select(x => x).ToList();
            for (int i = 0; i < folders.Count -1; i++)
            {
                if (folders[i+1] == "..")
                {
                    folders.RemoveAt(i);
                    folders.RemoveAt(i);
                    i -= i >= 2 ? 2 : i+1;
                }
            }
            return "/" + string.Join("/", folders.Where(x => x != string.Empty && x != ".."));
    }
}