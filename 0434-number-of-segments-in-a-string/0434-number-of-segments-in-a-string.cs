public class Solution
{
    public int CountSegments(string s)
    {
        if (s.Length == 0) return 0;
        if (string.IsNullOrWhiteSpace(s)) return 0;

        var i = 1;
        s = s.Trim();
        var start = false;
        var end = false;
        var atLeastOne = false;
        var c = 0;
        while (i < s.Length - 1)
        {
            if (s[i - 1] != ' ' && s[i] == ' ')
            {
                start = true;
                atLeastOne = true;
            }

            if (s[i + 1] != ' ' && s[i] == ' ')
            {
                end = true;
                atLeastOne = true;
            }

            if (start && end)
            {
                start = false;
                end = false;
                c++;
            }

            i++;
        }

        if (!atLeastOne & s.Length > 0)
        {
            return 1;
        }

        return c == 0 ? 0 : c + 1;
    }
}