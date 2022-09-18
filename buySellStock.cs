public class Solution {
    public int MaxProfit(int[] prices) {
        int l = 0;
        int r = 1;
        int profit = 0;
        while (r < prices.Length) {
            int currentProfit = prices[r] - prices[l];
            if (prices[l] < prices[r]) profit = Math.Max(currentProfit, profit);
            else l = r;
            r++;
        }
        return profit;
    }
}