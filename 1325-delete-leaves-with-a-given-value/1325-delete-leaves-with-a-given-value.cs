/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode RemoveLeafNodes(TreeNode root, int target)
    {
        RemoveLeafNodes(root, target, null);
        return root.val == target && root.right == null && root.left == null ? null : root;
    }

    public void RemoveLeafNodes(TreeNode root, int target, TreeNode parent)
    {
        if (root.left != null)
        {
            RemoveLeafNodes(root.left, target, root);
        }
        if (root.right != null)
        {
            RemoveLeafNodes(root.right, target, root);
        }
        if (root.val == target && root.right == null && root.left == null && parent != null)
        {
            if (parent.left == root)
            {
                parent.left = null;
            }
            else if (parent.right == root)
            {
                parent.right = null;
            }
        }
    }
}