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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if (p == null && q == null) return true;
        if (p == null && q != null) return false;
        if (p != null && q == null) return false;

        var same = p.val == q.val;

        if (!same) return false;

        same = same && IsSameTree(p.left, q.left);
        if (!same) return false;

        same = same && IsSameTree(p.right, q.right);
        return same;
    }
}