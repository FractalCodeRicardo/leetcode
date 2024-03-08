public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        if (nums.Length == 0) return -1;

        if (nums[0]> target) return 0;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == target) return i;
            if (nums[i + 1] == target) return i + 1;

            if (nums[i] < target && nums[i + 1] > target)
            {
                return i + 1;
            }

        }
        if (nums[nums.Length -1 ] == target) return nums.Length -1;
        if (nums[nums.Length -1 ]< target) return nums.Length;

        return -1;
    }
}