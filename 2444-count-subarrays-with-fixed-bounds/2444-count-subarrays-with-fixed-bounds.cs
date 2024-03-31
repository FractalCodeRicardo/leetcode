public class Solution {
    public long CountSubarrays(int[] nums, int minK, int maxK)
    {
        // Solution again damn :/
        //

        var badi = -1;
        var min = -1;
        var max = -1;

        long count = 0;

        var i = 0;

        while (i < nums.Length)
        {
            var n = nums[i];

            if (n > maxK || n < minK)
            {
                badi = i;
            }

            if (n == maxK)
                max = i;

            if (n == minK)
                min = i;

            count += Math.Max(0, Math.Min(min, max) - badi);

            i++;
        }

        return count;
    }
}