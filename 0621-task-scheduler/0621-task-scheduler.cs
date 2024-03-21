
public class Solution {
    public int LeastInterval(char[] tasks, int n)
    {
        if (n == 0) return tasks.Length;
        if (tasks.Length == 0) return 0;

        var frequencies = new Dictionary<char, int>();

        foreach (var t in tasks)
        {
            if (frequencies.ContainsKey(t))
                frequencies[t]++;
            else
                frequencies[t] = 1;
        }

        var letters = frequencies
            .OrderByDescending(i => i.Value)
            .Select(i => i.Key)
            .ToList();

        var max = frequencies[letters[0]] - 1;

        var slots = max * n;

        for (int i = 1; i < letters.Count; i++)
        {
            var l = letters[i];
            slots = slots - Math.Min(max, frequencies[l]);
        }

            
        if (slots <= 0)
            return tasks.Length;

        return slots + tasks.Length;
    }
}