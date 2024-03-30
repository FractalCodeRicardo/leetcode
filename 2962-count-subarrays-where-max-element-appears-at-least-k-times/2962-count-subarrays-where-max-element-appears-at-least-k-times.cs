public class Solution
{
    public long CountSubarrays(int[] nums, int k)
    {
        // Had to see the solution :/
        var max = nums.Max();

        var end = 0;
        var start = 0;
        var countK = 0;

        long res = 0;

        while (end < nums.Length)
        {
            if (nums[end] == max)
            {
                countK++;
            }

            while (countK == k)
            {
                if (nums[start] == max)
                {
                    countK--;
                }

                start++;
            }

            res += start;

            end++;
        }

        return res;
    }
}