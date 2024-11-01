using System.Text;

public class Solution {
    public string MakeFancyString(string s) {
        
        var i = 0;
        var f = 0;
        var r = new StringBuilder();
        while(i < s.Length && f < s.Length) {
            
            while(f < s.Length && s[i] == s[f]) f++;

            if (f - i >= 3) {
                r.Append(s[i].ToString() + s[i]);
            } else {
                r.Append(s.Substring(i, f -i));
            }

            i = f;
        }

        return r.ToString();
    }
}