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

public class Solution
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        var output = new List<int>();
        InOrder(root, output);
        return output;
    }

    public void InOrder(TreeNode root, List<int> output)
    {
        if ( root == null) return;

        InOrder(root.left, output);
        output.Add(root.val);
        InOrder(root.right, output);

    }
}