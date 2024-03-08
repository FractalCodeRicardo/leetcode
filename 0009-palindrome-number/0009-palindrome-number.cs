public class Solution
{
    public bool IsPalindrome(int x)
    {
        var str = x + "";
        var start = 0;
        var end = str.Length - 1;

        while(start<str.Length) {
            if (str[start] != str[end]) {
                return false;
            }
            start++;
            end--;
        }

        return true;
    }
}