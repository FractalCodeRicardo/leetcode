public class Solution {
       public int[][] Insert(int[][] intervals, int[] newInterval)
    {

        var i = 0;
        var output = intervals.ToList();

        if (output.Count == 0)
        {
            output.Add(newInterval);
            return output.ToArray();
        }

        var last = output[output.Count - 1];
        if (last[1] < newInterval[0])
        {
            output.Add(newInterval);
            return output.ToArray();
        }



        if (output.Count == 1)
        {

            if (overlaps(output[0], newInterval))
            {
                output[0] = merge(output[0], newInterval);
                return output.ToArray();
            }

            if (output[0][0] < newInterval[1])
            {
                output.Add(newInterval);
                return output.ToArray();
            }
            else
            {
                output.Insert(0, newInterval);
                return output.ToArray();

            }


        }

        if (output[0][0] >  newInterval[1])
        {
            output.Insert(0, newInterval);
            return output.ToArray();
        }

        while (i < output.Count - 1)
        {
            var i1 = output[i];
            var i2 = output[i + 1];

            if (i1[1] < newInterval[0] && newInterval[1] < i2[0])
            {
                output.Insert(i + 1, newInterval);
                return output.ToArray();
            }

            if (overlaps(i1, newInterval))
            {

                var replace = merge(i1, newInterval);
                while (i + 1 < output.Count)
                {
                    var next = output[i + 1];
                    var overlaping = overlaps(replace, next);
                    if (!overlaping) break;

                    replace = merge(replace, next);
                    output.RemoveAt(i + 1);
                }

                output[i] = replace;

                return output.ToArray();
            }


            i++;

        }

        last = output[output.Count - 1];
        if (overlaps(last, newInterval)) {
            output[output.Count -1 ] = merge(last, newInterval);
        }

        return output.ToArray();

    }

    public int[] merge(int[] n1, int[] n2)
    {
        return [Math.Min(n1[0], n2[0]), Math.Max(n1[1], n2[1])];
    }
    public bool overlaps(int[] n1, int[] n2)
    {
        return (n1[0] <= n2[0] && n2[0] <= n1[1]) ||
        (n1[0] <= n2[1] && n2[1] <= n1[1]) ||
        (n2[0] <= n1[0] && n1[0] <= n2[1]) ||
        (n2[0] <= n1[1] && n1[1] <= n2[1]);
    }
}