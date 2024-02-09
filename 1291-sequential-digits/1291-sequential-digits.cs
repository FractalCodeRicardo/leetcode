public class Solution {

 public IList<int> SequentialDigits(int low, int high)
    {
        var output = new HashSet<int>();
        int start = low.ToString().Length;
        int end = high.ToString().Length;

        for (int numDigits = start; numDigits <= Math.Min(end, 9); numDigits++)
        {
            for (int i = 1; i <= 9; i++)
            {
                int j = i;
                string cad = "";

                int c = 0;
                while (c < numDigits && j < 10)
                {
                    cad = cad + j;
                    j++;
                    c++;
                }

                var number = long.Parse(cad);

                if (low <= number && number <= high)
                {
                    output.Add((int)number);
                }
            }
        }

        var list = output.ToList();
        list.Sort();
        
        return list;
    }
}