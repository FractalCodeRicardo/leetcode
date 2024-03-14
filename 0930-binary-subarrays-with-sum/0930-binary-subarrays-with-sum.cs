public class Solution
{
     public int NumSubarraysWithSum(int[] nums, int goal) {
        var i = 0;
        var c = 0;
        while (i < nums.Length)
        {
            var k = i;
            var sum = 0;

            while (k < nums.Length) {
                sum += nums[k];
                if (sum == goal) c++;
                if (sum > goal) break;
                k++;
            }

            i++;
        }

        return c;
     }
}