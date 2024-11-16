using System.Security.Principal;

public class Solution
{
    public bool IsHappy(int n)
    {
        var results = new HashSet<int>();
        var res = n;

        while (true)
        {
            var cres = 0;
            var digits = res.ToString();

            foreach (var d in digits)
            {
                cres = cres + (int)Math.Pow( int.Parse(d.ToString()), 2);

            }
            if (results.Contains(cres)) return false;
            if (cres == 1) return true;
            res = cres;
            results.Add(cres);
        }

        return false;
    }

}