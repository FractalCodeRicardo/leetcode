public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        var list = new HashSet<int>();
        foreach (var n1 in nums1)
        {
            foreach (var n2 in nums2)
            {
                if (n1 == n2)
                {
                    list.Add(n1);
                }

            }
        }


        return list.ToArray();
    }
}