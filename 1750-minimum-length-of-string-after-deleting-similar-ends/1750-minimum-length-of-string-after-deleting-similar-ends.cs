public class Solution {

public int MinimumLength(string s)
    {

        while (s.Length > 1)
        {

            if (s[0] != s[s.Length - 1]) break;

            s = removeLeft(s, s[0]);

            if (s.Length > 0)
            {
                s = removeRight(s, s[s.Length - 1]);
            }


        }
        return s.Length;
    }

    public string removeLeft(string s, char c)
    {
        var k = 0;

        while (k < s.Length && s[k] == c) k++;

        return s.Substring(k);
    }

    public string removeRight(string s, char c)
    {
        var k = 0;
        var i = s.Length - 1;

        while (i > -1 && s[i] == c)
        {
            k++;
            i--;
        }

        return s.Substring(0, s.Length - k);
    }

}