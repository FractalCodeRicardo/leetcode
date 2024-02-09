public class Data
{
    public int index;
    public int count;
}

public class Solution {
 public int FirstUniqChar(string s)
    {
        var dict = new Dictionary<string, Data>();
        var i = 0;
        foreach (var item in s)
        {
            if (!dict.ContainsKey(item.ToString()))
            {
                dict[item.ToString()] = new Data { index = i, count = 1 };
            }
            else
            {
                var data = dict[item.ToString()];
                data.count = data.count + 1;
            }

            i++;
        }

        int? min = null;
        foreach (var entry in dict)
        {
            if (entry.Value.count == 1)
            {
                if (min == null || entry.Value.index < min)
                {
                    min = entry.Value.index;
                }
            }
        }

        return min == null ? -1 : min.Value;
    }
}