public class Solution {
    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target) {
        var c = 0;

        foreach(var h in hours) {
            if (h >= target) {
                c++;
            }
        }

        return c;
    }
}