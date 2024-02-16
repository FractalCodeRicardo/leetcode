public class Solution {
  public int[] RearrangeArray(int[] nums)
  {
    var output = new List<int>();
    var pi = 0;
    var ni = 0;
    while (output.Count < nums.Length)
    {
      while (pi < nums.Length && nums[pi] < 0) pi++;
      while (ni < nums.Length && nums[ni] >= 0) ni++;

      output.Add(nums[pi]);
      output.Add(nums[ni]);

      pi++;
      ni++;
    }

    return output.ToArray();

  }
}