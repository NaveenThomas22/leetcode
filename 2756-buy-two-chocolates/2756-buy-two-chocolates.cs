public class Solution {
    public int BuyChoco(int[] prices, int money) {
        Array.Sort(prices); 

        int minSum = int.MaxValue;

        for (int i = 0; i < prices.Length; i++) {
            for (int j = i + 1; j < prices.Length; j++) {
                int sum = prices[i] + prices[j];
                if (sum <= money) {
                    minSum = Math.Min(minSum, sum);
                }
            }
        }

        if (minSum == int.MaxValue) {
            return money;
        }

        return money - minSum;
    }
}
