class CoinChangeDPMemoization
{
    public int MinCoins(int[] coins, int sum)
   {
        // -1 no calc was done yet
        int[,] dp = new int[coins.Length, sum + 1]; // dp[n, sum] = minCoints

        for (int i = 0; i < dp.GetLength(0); i++)
        {
            for (int j = 0; j < dp.GetLength(1); j++)
            {
                dp[i, j] = -1;
            }
        }

        var minCount = MinCoins(coins, coins.Length - 1, sum, dp);

        if (minCount >= int.MaxValue - 1) return -1;

        return minCount;
    }

    private int MinCoins(int[] coins, int n, int sum, int[,] dp)
    {
        // Base case: if sum equals 0, then no coins are required
        if (sum == 0) return 0;

        // If sum is negative or no coins are left, then it is impossible to make sum
        if (sum < 0 || n < 0) return int.MaxValue - 1;

        // Use cashe
        if (dp[n, sum] != -1) return dp[n, sum];

        // It is required to cache function calls with different parameters combinations. This is why cache[n, sum] is 2D size
        int withCoin = 1 + MinCoins(coins, n, sum - coins[n], dp); // use (int.MaxValue - 1) as default to avoid int overflow here
        int withoutCoin = MinCoins(coins, n - 1, sum, dp);

        dp[n, sum] = Math.Min(withCoin, withoutCoin);

        return dp[n, sum];
    }
}

public static void Main(string[] args)
{
    int[] coins = { 1, 2, 5 };
    int sum = 11;

    int minCoins = new CoinChangeDPMemoization().MinCoins(coins, sum);

    if (minCoins == -1)
        Console.WriteLine("Не можливо скласти суму " + sum + " монетами.");
    else
        Console.WriteLine("Мінімальна кількість монет для суми " + sum + " гривень: " + minCoins);
}
