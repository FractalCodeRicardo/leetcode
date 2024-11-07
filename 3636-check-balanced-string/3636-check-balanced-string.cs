public class Solution
{
    public bool IsBalanced(string num)
    {
        var sumEven = 0;
        var sumOdd = 0;

        var i = 0;
        while (i < num.Length)
        {
            var s = int.Parse(num[i] + "");

            if (i % 2 == 0)
                sumEven += s;
            else
                sumOdd += s;
            i++;
        }

        return sumEven == sumOdd;
    }
}