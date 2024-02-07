public class Solution {
    public int LengthOfLongestSubstring(string s)
    {
        var currentMax = s.Length > 0 ? 1: 0;
        for (int i = 0; i < s.Length; i++)
        {
            var currentSubstring = s[i].ToString();
           
            for (int j = i + 1; j < s.Length; j++)
            {

                var nextChar = s[j].ToString();

                if (currentSubstring.Contains(nextChar)) {
                    break;
                }

                currentSubstring += nextChar;

                if (currentSubstring.Length > currentMax) {
                    currentMax = currentSubstring.Length;
                }

            }   
        }

        return currentMax;

    }
}