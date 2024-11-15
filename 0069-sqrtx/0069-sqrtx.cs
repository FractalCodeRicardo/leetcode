public class Solution
{
    public int MySqrt(int x)
    {
        if (x == 0) return 0;
        if (x == 1) return 1;
        if (x == 2) return 1;

        long i = 1;
        long last = 1;

        while(i < x) {

            if (i*i> x) {
                return (int)last;
            }
            last = i;
            i++;
        }

        throw new Exception("?");
    }
}