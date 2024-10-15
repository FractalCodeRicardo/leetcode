public class Solution {
    public int RemoveDuplicates(int[] nums) {

        var set = new HashSet<int>();

        foreach(var n in nums) {
            if(!set.Contains(n)) {
                set.Add(n);
            }
        }

        var i = 0;
        foreach(var s in set) {
            nums[i++] = s;
        }

       return set.Count(); 
    }
}