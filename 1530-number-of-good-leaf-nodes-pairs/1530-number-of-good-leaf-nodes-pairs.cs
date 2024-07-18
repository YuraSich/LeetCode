public class Solution {
    private int goodPairs = 0;
    
    public int CountPairs(TreeNode root, int distance) {
        DFS(root, distance);
        return goodPairs;
    }
    
    private List<int> DFS(TreeNode node, int distance)
    {
        var ret = new List<int>();
        // base cases
        if (node == null)
        {
            return ret;
        }
        if (IsLeafNode(node))
        {
            ret.Add(1);
            return ret;
        }
		// get distance to all leaf nodes from this nod
        var distanceLeft = DFS(node.left, distance);
        var distanceRight = DFS(node.right, distance);
		
		// go through and add up the distances, if they're less than distance it's a good pair
        foreach (var left in distanceLeft)
        {
            foreach (var right in distanceRight)
            {
                if (left + right <= distance)
                    goodPairs++;
            }
        }
		// combine all distances
        distanceLeft.AddRange(distanceRight);
		// increment each distance by one and return to parent node
        return distanceLeft.Select(i => i += 1).ToList();
    }
    
    private bool IsLeafNode(TreeNode node) =>
        node.left == null && node.right == null;
}