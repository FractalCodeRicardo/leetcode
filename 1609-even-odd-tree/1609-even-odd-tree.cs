
public class Solution
{

    public Dictionary<int, List<int>> values = new Dictionary<int, List<int>>();
    public bool IsEvenOddTree(TreeNode root)
    {
        getValues(root, 0);


        return checkOddEven();
    }

    public bool checkOddEven()
    {

        foreach (var key in values.Keys)
        {
            var isOdd = key % 2 != 0;
            
            if (values[key].Count == 1) {
                 var first = values[key][0];
                if (isOdd && (first % 2 != 0 )) return false;
                if (!isOdd && (first % 2 == 0 )) return false;
            }
           

            for (int i = 0; i < values[key].Count - 1; i++)
            {
                var first = values[key][i];
                var second = values[key][i + 1];

                if (isOdd && first <= second) return false;
                if (!isOdd && first >= second) return false;
                if (isOdd && (first % 2 != 0 || second % 2 != 0)) return false;
                if (!isOdd && (first % 2 == 0 || second % 2 == 0)) return false;
            }
        }

        return true;
    }

    public void getValues(TreeNode r, int level)
    {

        if (r == null) return;

        if (!values.ContainsKey(level))
        {
            values.Add(level, []);
        }

        values[level].Add(r.val);
        
        getValues(r.left, level + 1);
        getValues(r.right, level + 1);
    }
}