public class Solution
{
    public int RomanToInt(string s)
    {

        var i = 0;
        var value = 0;
        while (i < s.Length - 1) {
            var cval = Value(s[i]);
            var nval = Value(s[i+1]);

            if (cval < nval) {
                value += nval - cval;
                i = i + 2;
            } else {
                value += cval;
                i++;
            }
        }

        if (i == s.Length -1 ) {
            value += Value(s[i]);
        }

        return value;
    }

    public int Value(char c)
    {
        if (c == 'I') return 1;
        if (c == 'V') return 5;
        if (c == 'X') return 10;
        if (c == 'L') return 50;
        if (c == 'C') return 100;
        if (c == 'D') return 500;
        if (c == 'M') return 1000;

        throw new Exception("?");
    }
}