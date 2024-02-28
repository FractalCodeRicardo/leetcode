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
    public long value = long.MaxValue;
    public int ml = int.MaxValue;

    public int FindBottomLeftValue(TreeNode root)
    {
        int mlvl = maxLevel(root, -1);
        Console.WriteLine(mlvl);
 

        search(root,0,mlvl, 0);

        return (int)value;
    }

    public void search(TreeNode r, int clvl, int maxLvl, int ll) {
        if (r == null) return;
       // Console.WriteLine(r.val + "*" + clvl + "*" + ll );
        if (clvl == maxLvl && value > r.val && ml > ll) {
           value = r.val;
            ml = ll;
           return; 
        }
      

        search(r.left,clvl +1, maxLvl, ll -1);
        search(r.right,clvl +1, maxLvl, ll +1);
    }

    public int maxLevel(TreeNode r, int lvl)
    {
        if (r == null) return lvl;

        int lr = maxLevel(r.right, lvl + 1);
        int ll = maxLevel(r.left, lvl + 1);

        return Math.Max(lr, ll);
    }


}