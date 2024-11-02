public class Solution
{
    public uint reverseBits(uint n)
    {

        long number = n;
        var i = 31;
        var binary = "";
        while (i >= 0)
        {
            var pow = (long)Math.Pow(2, i);

            if (number / pow > 0)
            {
                binary = "1" + binary;
                number = number - pow;
            } else {
                binary = "0" + binary;
            }

            i--;
        }

        i = 31;
        long result = 0;
        foreach(var c in binary) {
            var pow = Math.Pow(2, i);
            result = result + (long)(c == '1' ? pow : 0);
            i--;
        }

        return (uint)result;
    }
}