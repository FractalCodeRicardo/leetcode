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
    public IList<int> PreorderTraversal(TreeNode root) {
        var output = new List<int>();
        PreOrder(root, output);

        return output;
    }

    public void PreOrder(TreeNode root, List<int> output) {

        if (root == null) return;

        output.Add(root.val);
        PreOrder(root.left, output);
        PreOrder(root.right, output);
    }
}