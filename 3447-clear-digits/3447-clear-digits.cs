public class Solution
{
    public string ClearDigits(string s)
    {

        while (true)
        {
            var newstring = Remove(s);

            if (newstring == "" || newstring == s)
                return newstring;

            s = newstring;

        }
    }

    public string Remove(string str)
    {
        var lastDigit = -1;
        var lastNonDigit = -1;

        var i = 0;

        while (i < str.Length)
        {
            var c = str[i];
            if (char.IsDigit(c))
            {
                lastDigit = i;
                break;
            }
            else
            {
                lastNonDigit = i;
            }

            i++;
        }

        if (lastDigit == -1)
            return str;

        var newstring = str.Remove(lastDigit, 1);

        if (lastNonDigit != -1)
        {
            newstring = newstring.Remove(lastNonDigit, 1);
        }

        return newstring;
    }
}