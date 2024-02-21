public class Solution {

    public int RangeBitwiseAnd(int left, int right) {
        long res = left;

        if (right == left) return right;
        if (right - left == 1) return right & left;

        for (long i = left + 1; i <= right; i++)
        {
            res = res & i; 

            if (res == 0) return 0; //if at least one cero all the operation is 0
        }

        return (int)res;
    }


}