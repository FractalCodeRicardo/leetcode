public class Solution {
    public int MajorityElement(int[] nums) {
        return nums
            .GroupBy(i => i)
            .Select(i => new {
                number = i.First(),
                count = i.Count()
            })
            .Where(i => i.count > Math.Floor(nums.Length / 2.0))
            .Select(i => i.number)
            .First();
    }
}