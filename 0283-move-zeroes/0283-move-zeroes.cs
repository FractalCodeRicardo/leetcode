public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        var nonZeros = nums.Where(i => i != 0);
        var zeros = nums.Where(i => i == 0);
        
        var output = new List<int>();
        output.AddRange(nonZeros);
        output.AddRange(zeros);

        for(var i = 0; i< nums.Length; i++) {
            nums[i] = output[i];
        }
    }
}