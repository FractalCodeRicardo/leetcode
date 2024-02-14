public class Solution {
    public string FirstPalindrome(string[] words)
    {
        foreach (var word in words)
        {
            if (isPalindrome(word))
            {
                return word;
            }
        }
        return "";
    }

    public bool isPalindrome(string c)
    {
        var i = 0;
        var k = c.Length - 1;

        while (i < c.Length)
        {
            if (c[i] != c[k]) return false;
            i++; k--;
        }

        return true;
    }
}