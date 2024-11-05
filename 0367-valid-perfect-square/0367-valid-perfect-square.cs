public class Solution {
    public bool IsPerfectSquare(int num) {

        if (num == 1) return true;
        long i = 0;

        while (i < num) {

            if ( i * i == num)
                return true;

            i++;
        }

        return false;
    }
}