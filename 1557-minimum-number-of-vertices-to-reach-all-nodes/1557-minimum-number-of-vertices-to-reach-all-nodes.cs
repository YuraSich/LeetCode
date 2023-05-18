public class Solution {
    public IList<int> FindSmallestSetOfVertices(int n, IList<IList<int>> edges) {
        bool[] isIncomingEdgeExists = new bool[n];
        foreach (var edge in edges) {
            isIncomingEdgeExists[edge[1]] = true;
        }

        var requiredNodes = new List<int>();
        for (int i = 0; i < n; i++) {
            if (!isIncomingEdgeExists[i]) {
                requiredNodes.Add(i);
            }
        }

        return requiredNodes;
    }
}