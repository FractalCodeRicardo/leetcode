public class Solution {
    public int PivotInteger(int n) {
       for (int i = 1; i <=n; i++)
       {
            var sum1 = sum(1, i);
            var sum2 = sum(i, n);

            if (sum1 == sum2) return i; 
       } 

       return -1;
    }

    public int sum(int from, int to) {
        var sum = 0;
        for (int i = from; i <= to; i++)
        {
           sum += i; 
        }

        return sum;
    }
}