public class Solution {
    private int minDifference = int.MaxValue;
    // Initially, it will be null.
    private TreeNode prevNode;

    public void InorderTraversal(TreeNode node) {
        if (node == null) {
            return;
        }

        InorderTraversal(node.left);
        // Find the difference with the previous value if it is there.
        if (prevNode != null) {
            minDifference = Math.Min(minDifference, node.val - prevNode.val);
        }
        prevNode = node;
        InorderTraversal(node.right);
    }

    public int GetMinimumDifference(TreeNode root) {
        InorderTraversal(root);
        return minDifference;
    }
}
