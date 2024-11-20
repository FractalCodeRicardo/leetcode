public class Solution {
    public int ScoreOfString(string s) {
        
        var i = 0;
        var sum = 0;
        while (i < s.Length -1) {
            var a = (int)s[i];
            var b = (int)s[i+1];

            sum = sum + Math.Abs(a-b);
            i++;
        }
        return sum;
    }
}