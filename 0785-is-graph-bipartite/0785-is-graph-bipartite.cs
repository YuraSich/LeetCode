public class Solution {
    public bool IsBipartite(int[][] graph) {
        int n = graph.Length;
        int[] colors = new int[n];
        
        for (int i = 0; i < n; i++) {       //This graph might be a disconnected graph. So check each unvisited node.
            if (colors[i] == 0 && !ValidColor(graph, colors, 1, i)) {
                return false;
            }
        }
        return true;
    }
    
    public bool ValidColor(int[][] graph, int[] colors, int color, int node) {
        if (colors[node] != 0) {
            return colors[node] == color;
        }
        
        colors[node] = color;
        
        foreach (int next in graph[node]) {
            if (!ValidColor(graph, colors, -color, next)) {
                return false;
            }
        }
        return true;
    }
}