public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        
        var i = 0;

        while (i < nums.Length ) {
            var ni = nums[i];
            var l = i + 1;

            while (l < nums.Length && Math.Abs(i - l) <= k ) {
                var nl = nums[l];

                if (nl == ni)
                    return true;
                l++;
            }
            i++;
        }

        return false;
    }
}
