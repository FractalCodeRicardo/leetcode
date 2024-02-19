public class Solution {
    public bool IsPowerOfTwo(int n) {
      return test(n);
    }

    public bool test(int n) {
      if (n == 0) return false;
      if(n == 1) return true;
      if(n % 2 != 0) return false;

      return test(n/2);
    }
}