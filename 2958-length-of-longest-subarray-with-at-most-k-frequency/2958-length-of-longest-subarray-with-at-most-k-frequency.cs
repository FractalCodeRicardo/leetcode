public class Solution
{
    public int MaxSubarrayLength(int[] nums, int k)
    {
        var counts = new Dictionary<int, int>();

        var to = 0;
        var from = 0;
        var max = 0;

        while (to < nums.Length)
        {
            var toNum = nums[to];

            if (counts.ContainsKey(toNum))
            {
                counts[toNum]++;
            }
            else
            {
                counts[toNum] = 1;
            }

            while (counts[toNum] > k)
            {
                var toFrom = nums[from];
                counts[toFrom]--;
                from++;
            }

            max = Math.Max(max, to - from + 1);

            to++;
        }
        return max;
    }


}