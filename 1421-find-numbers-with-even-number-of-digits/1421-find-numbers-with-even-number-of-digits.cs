public class Solution {
    public int FindNumbers(int[] nums) {
        return nums
            .Select(i => i.ToString())
            .Where(i => i.Length % 2 == 0)
            .Count();
    }
}