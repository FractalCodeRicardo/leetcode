public class Solution {
    public bool RotateString(string s, string goal) {
        if (s.Length != goal.Length)
            return false;

        var i = 0;

        while( i < s.Length) {
            s = s.Remove(0, 1) + s[0];

            if (s == goal)
                return true;

            i++;
        }
        return false;
    }
}