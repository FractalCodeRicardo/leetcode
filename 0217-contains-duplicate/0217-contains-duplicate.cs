public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        return nums
            .GroupBy(i => i)
            .Any(i => i.Count() > 1);
    }
}