public class Solution
{
 public int NumSubarrayProductLessThanK(int[] nums, int k)
    {
        var count = 0;

        var all = nums[0];
        for(int i = 1; i < nums.Length; i++) 
        {
            if (all >= k) break;
            all = all * nums[i];
        }

        if (all < k) return sumCombinations(nums.Length);

        for (int i = 0; i < nums.Length; i++)
        {
            var size = 1;
            while (i + size - 1 < nums.Length)
            {
                var from = i;
                var to = i + size - 1;

                if (!ProductLessThanK(nums, from, to, k))
                    break;

                count++;
                size++;
            }
        }

        return count;
    }

    public bool ProductLessThanK(int[] nums, int from, int to, int k)
    {
        var p = nums[from];
        if (p >= k)
            return false;
        for (int i = from + 1; i <= to; i++)
        {
            p = p * nums[i];

            if (p >= k)
                return false;
        }

        return true;
    }

    public int sumCombinations(int k) {
        int result = 0;
        for(int i = k; i > 0; i--) 
            result += i;

            return result;
    }

}