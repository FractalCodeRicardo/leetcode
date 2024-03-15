public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        var left = new int[nums.Length];
        var right = new int[nums.Length];

        right[nums.Length - 1] = 1;

        for (int i = nums.Length - 2; i >= 0; i--)
        {
            right[i] = right[i + 1] * nums[i+1];
        }

        left[0] = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            left[i] = left[i - 1] * nums[i - 1];
        }

        var res = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            res[i] = left[i] * right[i];
        }

        return res;

    }
}