public class Solution {
    public void ReverseString(char[] s) {
        var size = Math.Ceiling(s.Length / 2.0);

        var i = 0;
        var f = s.Length - 1;

        while(i < size) {

            var t = s[i];
            s[i] = s[f];
            s[f] = t;
            
            i++;
            f--;
        }
    }
}