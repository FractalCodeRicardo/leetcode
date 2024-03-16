public class Solution
{
    public int FindMaxLength(int[] nums)
    {
        // I had to see the solution
        var c = 0;
        var max = 0;
        var counts = new Dictionary<int, int>();
        counts[0] = -1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
                c++;
            else
                c--;

            if (counts.ContainsKey(c)) {
               var len = i - counts[c];
               max = Math.Max(max, len); 
            } else {
                counts[c] = i;
            }
            
        }
        return max;

    }

}