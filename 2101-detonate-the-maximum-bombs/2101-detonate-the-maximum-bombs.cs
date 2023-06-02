public class Solution {
    public int MaximumDetonation(int[][] bombs) {
        Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
        int n = bombs.Length;

        // Build the graph
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                int xi = bombs[i][0], yi = bombs[i][1], ri = bombs[i][2];
                int xj = bombs[j][0], yj = bombs[j][1];

                // Create a path from node i to node j, if bomb i detonates bomb j.
                if ((long)ri * ri >= (long)(xi - xj) * (xi - xj) + (long)(yi - yj) * (yi - yj)) {
                    if (!graph.ContainsKey(i)) {
                        graph.Add(i, new List<int>());
                    }
                    graph[i].Add(j);
                }
            }
        }

        int answer = 0;
        for (int i = 0; i < n; i++) {
            answer = Math.Max(answer, BFS(i, graph));
        }

        return answer;
    }

    private int BFS(int i, Dictionary<int, List<int>> graph) {
        Queue<int> queue = new Queue<int>();
        HashSet<int> visited = new HashSet<int>();
        queue.Enqueue(i);
        visited.Add(i);
        while (queue.Count > 0) {
            int cur = queue.Dequeue();
            foreach (int neib in graph.GetValueOrDefault(cur, new List<int>())) {
                if (!visited.Contains(neib)) {
                    visited.Add(neib);
                    queue.Enqueue(neib);
                }
            }
        }
        return visited.Count;
    }
}
