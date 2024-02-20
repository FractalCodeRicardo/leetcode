public class Solution {
    public int MissingNumber(int[] nums) {
        var set = new HashSet<int>();

        foreach(var n in nums) set.Add(n);

        for (int i = 0; i <=nums.Length; i++)
        {
           if(!set.Contains(i)) return i; 
        }
        

        throw new Exception("?");
        
    }
}