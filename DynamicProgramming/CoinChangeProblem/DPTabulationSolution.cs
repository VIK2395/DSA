namespace CoinChange
{
    internal class CoinChangeDPTabulation
    {
        public int MinCoins(int[] coins, int sum)
        {
            if (sum == 0) return 0;

            if (sum < 0 || coins.Length == 0) return - 1;

            int[,] dp = new int[coins.Length, sum + 1]; // dp[n, sum] = minCoints

            for (int i = 0; i < dp.GetLength(0); i++)
            {
                dp[i, 0] = 0; // sum equal to 0 is only when 0 coins are used
            }

            for (int i = 0; i < coins.Length; i++)
            {
                for (int j = 1; j <= sum; j++)
                {
                    int withCoin = int.MaxValue - 1;
                    int withoutCoin = int.MaxValue - 1;

                    if (j - coins[i] >= 0)
                    {
                        withCoin = 1 + dp[i, j - coins[i]]; // use (int.MaxValue - 1) as default to avoid int overflow here
                    }

                    if (i - 1 >= 0)
                    {
                        withoutCoin = dp[i - 1, j];
                    }

                    dp[i, j] = Math.Min(withCoin, withoutCoin); // recurrence relation
                }
            }

            if (dp[coins.Length - 1, sum] >= int.MaxValue - 1) return -1;

            return dp[coins.Length - 1, sum];
        }

        // Time Complexity O(cointsCount*sum)
        // Auxiliary Space O(cointsCount*sum)

        // https://www.youtube.com/watch?v=trB2PFMI19k
        // https://www.youtube.com/watch?v=Y0ZqKpToTic
    }
}
