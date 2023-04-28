using System.Collections.Generic;

public class Solution
{
    public void DFS(int node, Dictionary<int, List<int>> adj, bool[] visit)
    {
        visit[node] = true;
        if (!adj.ContainsKey(node))
        {
            return;
        }
        foreach (var neighbor in adj[node])
        {
            if (!visit[neighbor])
            {
                visit[neighbor] = true;
                DFS(neighbor, adj, visit);
            }
        }
    }

    public bool IsSimilar(string a, string b)
    {
        var diff = 0;
        for (var i = 0; i < a.Length; i++)
        {
            if (a[i] != b[i])
            {
                diff++;
            }
        }
        return diff == 0 || diff == 2;
    }

    public int NumSimilarGroups(string[] strs)
    {
        var n = strs.Length;
        Dictionary<int, List<int>> adj = new Dictionary<int, List<int>>();
        // Form the required graph from the given strings array.
        for (var i = 0; i < n; i++)
        {
            for (var j = i + 1; j < n; j++)
            {
                if (IsSimilar(strs[i], strs[j]))
                {
                    if (!adj.ContainsKey(i))
                    {
                        adj.Add(i, new List<int>());
                    }
                    adj[i].Add(j);
                    if (!adj.ContainsKey(j))
                    {
                        adj.Add(j, new List<int>());
                    }
                    adj[j].Add(i);
                }
            }
        }

        var visit = new bool[n];
        var count = 0;
        // Count the number of connected components.
        for (var i = 0; i < n; i++)
        {
            if (!visit[i])
            {
                DFS(i, adj, visit);
                count++;
            }
        }

        return count;
    }
}