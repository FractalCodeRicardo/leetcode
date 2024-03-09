public class Solution
{
    public int GetCommon(int[] nums1, int[] nums2)
    {
     

        var first = nums1;
        var second = nums2;

        if(nums1[0] > nums2[0]) {
            first = nums2;
            second = nums1;
        }

        for (int i = 0; i < first.Length; i++)
        {
            if (first[i]<second[0]) continue;
            for (int k = 0; k < second.Length; k++)
            {
                if(first[i] == second[k] ){

                    return first[i];
                }

            }
        }

        return -1;
    }
}