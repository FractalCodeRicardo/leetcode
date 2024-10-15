public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        if (needle.Length > haystack.Length)
            return -1;

        for (int i = 0; i < haystack.Length; i++)
        {
            for (int j = 0; j < needle.Length; j++)
            {
                if(i + j >= haystack.Length){
                    break;
                }

                var c1 = haystack[i + j];
                var c2 = needle[j];

                if (c1 != c2) break;

                if(j == needle.Length-1)
                    return i;

           }
        }

        return -1;
    }
}