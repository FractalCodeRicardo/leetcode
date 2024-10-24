public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        var r = 1;
        var output = new List<int>();
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            var d = digits[i];
            var dn = d + r;

            if (dn >= 10)
            {
                r = 1;
                output.Add(dn - 10);
            }
            else
            {
                r = 0;
                output.Add(dn);
            }
        }

        if (r == 1)
        {
            output.Add(1);
        }

         output.Reverse();

         return output.ToArray();
    }


}