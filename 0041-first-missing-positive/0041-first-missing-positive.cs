

public class Solution
{
    public int FirstMissingPositive(int[] nums)
    {
        var ordered = nums.Where(i => i > -1).OrderBy(i => i).ToList();
        
        if (ordered.Count == 0) return 1;
        if (ordered[0] > 0 && ordered[0] > 1)
            return 1;

        for (int i = 0; i < ordered.Count - 1; i++)
        {
            
            var a = ordered[i];
            var b = ordered[i + 1];
            

            if (a + 1 < b)
                return a + 1;
        }
        

        return ordered[ordered.Count -1] + 1;
    }
}