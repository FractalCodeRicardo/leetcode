public class Solution
{
    public int FindDuplicate(int[] nums)
    {
        var set = new HashSet<int>();

        foreach (var n in nums)
        {
            if (set.Contains(n)) return n;

            set.Add(n);
        }

        return -1;
    }
}