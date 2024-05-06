public class Solution {
    public string LongestCommonPrefix(string[] strs)
    {
        var i = 0;
        var cPrefix = "";

        while (true)
        {
            var first = strs[0];

             if (first.Length == 0 || first.Length - 1 < i)
            {
                return cPrefix;
            }

            var letter = first[i].ToString();

            var success = CheckLetter(letter, i, strs);

            if (!success)
            {
                return cPrefix;
            }

            cPrefix = cPrefix + letter;
            i++;
        }

    }

    public bool CheckLetter(string letter, int pos, string[] strs)
    {
        foreach (var str in strs)
        {
            if (str.Length - 1 < pos)
            {
                return false;
            }

            if (str[pos].ToString() != letter)
            {
                return false;
            }
        }

        return true;
    }


}