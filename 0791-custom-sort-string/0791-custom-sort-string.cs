public class Solution
{
    public string CustomSortString(string order, string s)
    {
        var output = "";
        foreach (var c in order)
        {


            while (s.Length > 0)
            {
                var i = s.IndexOf(c);

                if (i == -1) break;

                output = output + c;
                s = s.Remove(i, 1);

            }


        }

        if (s.Length > 0)
        {
            output = output + s;
        }

        return output;
    }
}