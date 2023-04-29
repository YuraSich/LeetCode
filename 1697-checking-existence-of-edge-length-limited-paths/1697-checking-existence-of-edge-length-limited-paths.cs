public class UnionFind {
    private int[] group;
    private int[] rank;
    
    public UnionFind(int size) {
        group = new int[size];
        rank = new int[size];
        for (int i = 0; i < size; ++i) {
            group[i] = i;
        }
    }

    public int Find(int node) {
        if (group[node] != node) {
            group[node] = Find(group[node]);
        }
        return group[node];
    }

    public void Join(int node1, int node2) {
        int group1 = Find(node1);
        int group2 = Find(node2);

        // node1 and node2 already belong to same group.
        if (group1 == group2) {
            return;
        }

        if (rank[group1] > rank[group2]) {
            group[group2] = group1;
        } else if (rank[group1] < rank[group2]) {
            group[group1] = group2;
        } else {
            group[group1] = group2;
            rank[group2] += 1;
        }
    }

    public bool AreConnected(int node1, int node2) {
        int group1 = Find(node1);
        int group2 = Find(node2);
        return group1 == group2;
    }
}

public class Solution {
    // Sort in increasing order based on the 3rd element of the array.
    private void Sort(int[][] array) {
        Array.Sort(array, (a, b) => a[2] - b[2]);
    }

    public bool[] DistanceLimitedPathsExist(int n, int[][] edgeList, int[][] queries) {
        UnionFind uf = new UnionFind(n);
        int queriesCount = queries.Length;
        bool[] answer = new bool[queriesCount];

        // Store original indices with all queries.
        int[][] queriesWithIndex = new int[queriesCount][];
        for (int i = 0; i < queriesCount; ++i) {
            queriesWithIndex[i] = new int[] { queries[i][0], queries[i][1], queries[i][2], i };
        }

        // Sort all edges in increasing order of their edge weights.
        Sort(edgeList);
        // Sort all queries in increasing order of the limit of edge allowed.
        Sort(queriesWithIndex);

        int edgesIndex = 0;

        // Iterate on each query one by one.
        for (int queryIndex = 0; queryIndex < queriesCount; queryIndex += 1) {
            int p = queriesWithIndex[queryIndex][0];
            int q = queriesWithIndex[queryIndex][1];
            int limit = queriesWithIndex[queryIndex][2];
            int queryOriginalIndex = queriesWithIndex[queryIndex][3];

            // We can attach all edges which satisfy the limit given by the query.
            while (edgesIndex < edgeList.Length && edgeList[edgesIndex][2] < limit) {
                int node1 = edgeList[edgesIndex][0];
                int node2 = edgeList[edgesIndex][1];
                uf.Join(node1, node2);
                edgesIndex += 1;
            }

            // If both nodes belong to the same component, it means we can reach them. 
            answer[queryOriginalIndex] = uf.AreConnected(p, q);
        }

        return answer;
    }
}