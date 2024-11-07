public class Solution {
    public int AddDigits(int num) {
        var strNum = num.ToString();

        while(true) {
            var sum = 0;
            foreach(var c in strNum) {
                sum = sum + int.Parse(c + "");
            }

            if (sum < 10) {
                return sum;
            }

            strNum = sum.ToString();
        }
    }
}