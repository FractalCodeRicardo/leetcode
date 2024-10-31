public class Solution {
    public bool IsPalindrome(string s) {
        
        var letters = "";

        foreach(var c in s) {
            if (Char.IsLetter(c)|| Char.IsDigit(c) ) {
                letters = letters + c;
            }
        }

        letters = letters.ToLower();

        var x = letters.Length -1;
        var i = 0;

        while (i < letters.Length) {

            if (letters[i] != letters[x])
                return false;
            x--;
            i++;
        }

        return true;
    }
}