public class Solution
{
    public IList<int> FindDuplicates(int[] nums)
    {
        var numbers = new Dictionary<int, int>();

        foreach (var n in nums)
        {
            if (numbers.ContainsKey(n))
            {
                numbers[n]++;
            }
            else
            {
                numbers[n] = 1;
            }
        }

        var list = numbers.Where(i => i.Value == 2).Select(i => i.Key);

        return list.ToList();
    }
}