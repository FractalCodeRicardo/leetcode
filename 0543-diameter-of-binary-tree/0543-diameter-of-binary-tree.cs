public class Solution 
{
    public int maxValue = int.MinValue; 
    public int DiameterOfBinaryTree(TreeNode root)
    {
        findMax(root);
        return maxValue;
    }

    public void findMax(TreeNode r) {
        if (r == null ) return;

        var ll = maxLevel(r.left);
        var lr = maxLevel(r.right);

        if (maxValue < ll + lr) {
            maxValue = ll + lr;
        }

        findMax(r.left);
         findMax(r.right);
    }
    public int maxLevel(TreeNode r) {
        if (r == null ) return 0;

        var ll = maxLevel(r.left);
        var lr = maxLevel(r.right);

        return Math.Max(ll, lr) + 1;
    }
}