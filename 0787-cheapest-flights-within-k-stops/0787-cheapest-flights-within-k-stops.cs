public class Solution
{
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
    {
        var paths = new int[n];
        for (int i = 0; i < n; i++)
        {
            if (i == src)
                paths[i] = 0;
            else
                paths[i] = int.MaxValue;
        }

        var queue = new Queue<int[]>();

        queue.Enqueue([src, 0]);
        var stops = 0;

        while (queue.Count > 0 && stops <= k)
        {

            int size = queue.Count;
            while (size-- > 0)
            {

                var pivot = queue.Dequeue();
                var cSrc = pivot[0];
                var cPrice = pivot[1];

                for (int i = 0; i < flights.Length; i++)
                {
                    var f = flights[i];
                    var from = f[0];
                    var to = f[1];
                    var price = f[2];

                    if (from == cSrc)
                    {

                        if (paths[to] > cPrice + price)
                        {
                            paths[to] = cPrice + price;
                            queue.Enqueue([to, cPrice + price]);
                        }

                    }

                }
            }
            stops++;
        }

        return paths[dst] == int.MaxValue ? -1 : paths[dst];
    }

}