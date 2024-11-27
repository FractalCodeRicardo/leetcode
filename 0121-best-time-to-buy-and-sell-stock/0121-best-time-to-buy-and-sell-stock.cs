public class Solution {
    public int MaxProfit(int[] prices) {
        var max = -int.MaxValue;

        var l = prices[0];
        var i = 1;

        while (i < prices.Length) {
            var price = prices[i];

            if (price < l) {
                l = price;
            }

            max = Math.Max(max, price - l);
            i++;
        }

        return max < 0 ? 0 : max;
    }
}