public class Solution
{
    public int LengthOfLastWord(string s)
    {

        if (s == null || s.Length == 0) return 0;

        var splitted = s.Split(" ");

        var i = splitted.Length - 1;

        while (i >= 0) {

            var str = splitted[i].Trim();

            if (str.Length >0) {
                return str.Length;
            }

            i--;
        }

        return 0;
    }
}