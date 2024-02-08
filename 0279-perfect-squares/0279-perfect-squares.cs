public class Solution {
   
  int least = int.MaxValue;
    bool found = false;
    public int NumSquares(int n)
    {
        List<int> squares = GetSquares(n);

        for (int i = 1; i <= n && !found; i++)
        {
            combine(squares, n, 0, i, "");
        }


        return least;
    }

    public void combine(List<int> list, int sum, int currentSize, int maxSize, string console)
    {

        if (currentSize > maxSize) return;
        if (sum < 0) return;
        if (found) return;

        //Console.WriteLine(console);
        if (sum == 0)
        {
            found = true;
            least = currentSize;
        }

        if (currentSize < maxSize)
        {

            foreach (var next in list)
            {
                string text = console + " " + next;
                combine(list, sum - next, currentSize + 1, maxSize, text);
            }
        }


    }

    private static List<int> GetSquares(int n)
    {
        var squares = new List<int>();

        int i = 1;

        do
        {
            squares.Add((int)Math.Pow(i, 2));
            i++;
        } while ((int)Math.Pow(i, 2) <= n);

        squares.Reverse();

        return squares;
    }


}