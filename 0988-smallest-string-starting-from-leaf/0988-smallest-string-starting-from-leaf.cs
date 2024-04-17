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
    public string SmallestFromLeaf(TreeNode root) {
        var smallestString = "";
        var queue = new Queue<KeyValuePair<TreeNode, string>>();

        // Enqueue root node to queue along with its value converted to a character
        queue.Enqueue(new KeyValuePair<TreeNode, string>(root, ((char)(root.val + 'a')).ToString()));

        // Perform BFS traversal until queue is empty
        while (queue.Count > 0) {

            // Pop the leftmost node and its corresponding string from queue
            var pair = queue.Dequeue();
            var node = pair.Key;
            var currentString = pair.Value;
    
            // If current node is a leaf node
            if (node.left == null && node.right == null) {
            
                // Update smallest_string if it's empty or current string is smaller
                if (string.IsNullOrEmpty(smallestString)) {
                    smallestString = currentString;
                } else {
                    smallestString = currentString.CompareTo(smallestString) < 0 ? currentString : smallestString;
                }
            }

            // If current node has a left child, append it to queue
            if (node.left != null) {
                queue.Enqueue(new KeyValuePair<TreeNode, string>(node.left, (char)(node.left.val + 'a') + currentString));
            }

            // If current node has a right child, append it to queue
            if (node.right != null) {
                queue.Enqueue(new KeyValuePair<TreeNode, string>(node.right, (char)(node.right.val + 'a') + currentString));
            }
        }

        return smallestString;        
    }
}