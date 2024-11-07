public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        var sValues = new Dictionary<char, int>();
        var tValues = new Dictionary<char, int>();

        var i = 0;
        while(i < s.Length) {

            if (sValues.ContainsKey(s[i])){
                sValues[s[i]]++;
            } else {
                sValues[s[i]] = 1;
            }
             if (tValues.ContainsKey(t[i])){
                tValues[t[i]]++;
            } else {
                tValues[t[i]] = 1;
            }
            
            i++;
        }
        var keys = sValues.Keys;
        foreach(var k in keys) {
            if(!tValues.ContainsKey(k))
                return false;
            
            if(sValues[k] != tValues[k])
                return false;
        }

        return true;
    }
}