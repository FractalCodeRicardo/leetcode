public class Solution {
   public string LongestPalindrome(string s)
    {
        var cSize = s.Length;

        while (cSize >= 1)
        {
            var i = 0;
            while (i <= s.Length - 1 && i + cSize <= s.Length)
            {
                var palindrome = s.Substring(i, cSize);

                if (isPalindrome(palindrome))
                {
                    return palindrome;
                }

                i++;
            }

            cSize--;
        }

        return "";
    }

    public bool isPalindrome(string cad)
    {
        var i = 0;
        var j = cad.Length - 1;
        while (i < cad.Length)
        {
            if (cad[i].ToString() != cad[j].ToString())
            {
                return false;
            }
            i++;
            j--;
        }
        return true;
    }
}