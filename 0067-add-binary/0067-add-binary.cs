public class Solution
{
    public string AddBinary(string a, string b)
    {

        var size = Math.Max(a.Length, b.Length);
        a = new string('0', size - a.Length) + a;
        b = new string('0', size - b.Length) +b;

        var i = size - 1;
        var rem = 0;
        var result = "";
        while (i >= 0)
        {
            var av = a[i] == '1' ? 1 : 0;
            var bv = b[i] == '1' ? 1 : 0;

            var total = av + bv + rem;

            if (total == 0)
            {
                result = "0" + result;
                rem = 0;
            }

            if (total == 1)
            {
                result = "1" + result;
                rem = 0;
            }

            if (total == 2)
            {
                result = "0" + result;
                rem = 1;
            }

             if (total == 3) {
                result = "1" + result;
                rem = 1;
            }

            i--;
        }

        if (rem == 1) {
            result = "1" + result;
        }

        return result;
    }
}