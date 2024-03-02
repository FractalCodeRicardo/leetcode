public class Solution {
    public int[] SortedSquares(int[] nums) {
        return nums.Select(i => i * i).Order().ToArray();
    }
}