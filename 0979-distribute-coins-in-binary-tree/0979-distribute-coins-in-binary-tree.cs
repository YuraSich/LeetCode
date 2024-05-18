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
    public int DistributeCoins(TreeNode root) {
        int moves = 0;
        DFS(root, ref moves);
        return moves;
    

        static int DFS(TreeNode node, ref int moves)
        {
            if(node == null)
            {
                return 0;
            }

            var l = DFS(node.left, ref moves);
            var r = DFS(node.right, ref moves);

            moves += Math.Abs(l) + Math.Abs(r);

            return node.val - 1 + l + r;
        }
    }
}