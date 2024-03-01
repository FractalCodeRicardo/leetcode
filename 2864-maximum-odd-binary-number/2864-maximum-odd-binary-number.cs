public class Solution {
    public string MaximumOddBinaryNumber(string s)
    {
        int onesLeft = 0;

        onesLeft = s.Where(i => i == '1').Count() - 1;

        var ones = new String('1', onesLeft);
        var zeros = new String('0', s.Length - 1 - onesLeft);

        return ones + zeros + '1';
    }
}