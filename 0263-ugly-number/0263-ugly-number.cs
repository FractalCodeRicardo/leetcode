public class Solution
{
    public bool IsUgly(int n)
    {
        if (n == 1) return true;
        if (n == 0) return false;

        var toDivide = n;
        var primes = new List<int> { 2, 3, 5 };
        while (true)
        {
            var isDivided = false;
            foreach (var prime in primes)
            {

                if (toDivide % prime == 0)
                {
                    toDivide = toDivide / prime;
                    isDivided = true;
                    break;
                }
            }

            if (!isDivided)
            {
                return false;
            }

            if (toDivide == 1)
            {
                return true;
            }
        }

    }
}