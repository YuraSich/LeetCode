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
    public int WidthOfBinaryTree(TreeNode root) {
        if (root == null) {
            return 0;
        }
        
        int max = 0;
        Queue<Tuple<TreeNode, int>> queue = new Queue<Tuple<TreeNode, int>>();
        queue.Enqueue(new Tuple<TreeNode, int>(root, 0));
        
        while (queue.Count > 0) {
            int size = queue.Count;
            int left = 0, right = 0;
            
            for (int i = 0; i < size; i++) {
                Tuple<TreeNode, int> tuple = queue.Dequeue();
                TreeNode node = tuple.Item1;
                int pos = tuple.Item2;
                
                if (i == 0) {
                    left = pos;
                }
                
                if (i == size - 1) {
                    right = pos;
                }
                
                if (node.left != null) {
                    queue.Enqueue(new Tuple<TreeNode, int>(node.left, pos * 2));
                }
                
                if (node.right != null) {
                    queue.Enqueue(new Tuple<TreeNode, int>(node.right, pos * 2 + 1));
                }
            }
            
            max = Math.Max(max, right - left + 1);
        }
        
        return max;
    }
}