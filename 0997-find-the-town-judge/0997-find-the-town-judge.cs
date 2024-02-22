public class Solution {
    public int FindJudge(int n, int[][] trust)
    {
        if(trust.Length == 0 && n == 1) return n;

        for (int i = 1; i <= n; i++)
        {
            var trustNoBody = true;
            for (int x = 0; x < trust.Length; x++)
            {
                var a = trust[x][0];

                if (a == i)
                {
                    trustNoBody = false;
                    break;
                }
            }

            if (!trustNoBody) continue;

            var relCount = 0;
           for (int k = 1; k <= n ; k++)
            {
                if (i == k) continue;
                for (int x = 0; x < trust.Length; x++)
                {
                    var a = trust[x][0];
                    var b = trust[x][1];

                    if (b == i && a == k)
                    {
                        relCount++;
                         if (relCount == n - 1) return i;
                    };

                }
            }

        }
        return -1;
    }
}