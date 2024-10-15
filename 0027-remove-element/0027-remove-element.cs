public class Solution {
    public int RemoveElement(int[] nums, int val) {
        
        var noVals = nums
            .Where(i => i != val)
            .ToList();

        var i = 0;

        foreach(var n in noVals) {
            nums[i++] = n;
        }

        nums = nums.Take(noVals.Count()).ToArray();

        return noVals.Count();
    }
}