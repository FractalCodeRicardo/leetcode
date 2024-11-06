public class Solution {
    public bool IsPowerOfThree(int n) {
        
        var values = new HashSet<long>();

        long c = 0;
        var  i = 0;
        while (c < n) {
            c = (long)Math.Pow(3,i);
            values.Add(c);
            i++;
        }

        return values.Contains(n);
    }
}