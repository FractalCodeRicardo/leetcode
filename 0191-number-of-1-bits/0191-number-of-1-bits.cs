public class Solution {
    public int HammingWeight(int n) {
        var i = 31;
        var c = 0;
        while(i >= 0 || n > 0) {

            var t =(int) Math.Pow(2, i);

            if (n / t > 0) {
                n = n -t;
                c++;
            }

            i--;
        }

        return c;
    }
}