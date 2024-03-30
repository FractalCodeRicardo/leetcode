public class Solution
{
   public int SubarraysWithKDistinct(int[] nums, int k)
    {
        var firstCount = subarray(nums, k);
        var secondCount = subarray(nums, k - 1);
        return firstCount - secondCount;
    }

    public int subarray(int[] nums, int k)
    {
        var end = 0;
        var goods = new Dictionary<int, int>();
        var start = 0;
        var count = 0;

        while (end < nums.Length)
        {
            if (!goods.ContainsKey(nums[end]))
            {
                goods[nums[end]] = 1;
            }
            else
            {
                goods[nums[end]]++;
            }

            while (goods.Count > k)
            {
                goods[nums[start]]--;

                if (goods[nums[start]] == 0)
                {
                    goods.Remove(nums[start]);
                }

                start++;
            }

            count = count + end - start + 1;
            end++;
        }

        return count;
    }


}