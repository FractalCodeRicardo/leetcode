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
    public IList<int> PostorderTraversal(TreeNode root) {
        var output = new List<int>();        
        run(root, output);
        return output;
    }

    public void run(TreeNode root, List<int> output) {

        if (root == null) return;

        run(root.left, output);
        run(root.right, output);
        output.Add(root.val);
    }
}