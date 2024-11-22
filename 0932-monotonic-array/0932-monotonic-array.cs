public class Solution
{
    public bool IsMonotonic(int[] nums)
    {
        var increasing = true;
        var decreasing = true;

        var i = 0;

        while (i < nums.Length - 1)
        {
            if (nums[i] > nums[i + 1])
            {
                increasing = false;
                break;
            }
            i++;
        }

        i = 0;
        while (i < nums.Length - 1)
        {
            if (nums[i] < nums[i + 1])
            {
                decreasing = false;
                break;
            }
            i++;
        }

        return increasing || decreasing; 
    }
}