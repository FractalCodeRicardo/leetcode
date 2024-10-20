public class Solution {
    public int SingleNumber(int[] nums) {
        return nums
            .GroupBy(i => i)
            .Where(i=> i.Count() == 1)
            .Select(i => i.First())
            .First();
    }
}