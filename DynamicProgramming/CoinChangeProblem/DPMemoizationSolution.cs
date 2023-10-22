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

        // Use cache // prevents unnecessary recursive calls 
        if (dp[n, sum] != -1) return dp[n, sum];

        // It is required to cache function calls with different parameters combinations. This is why cache[n, sum] is 2D size
        int withCoin = 1 + MinCoins(coins, n, sum - coins[n], dp); // use (int.MaxValue - 1) as default to avoid int overflow here
        int withoutCoin = MinCoins(coins, n - 1, sum, dp);

        dp[n, sum] = Math.Min(withCoin, withoutCoin);

        return dp[n, sum];
    }
}

// We still have some recursive calls.
// On line 37, we iterate through sum. In worst case, from sum to 0 with step 1;
// On line 38, we iterate through n(coins), from n to 0;
// Taking in account the cache(excludes the same calcs), calls on lines 37 and 38 will call each other making cointsCount*(sum+1) combinations, like loop inside loop;
// Or
// Because of cache, in the worst case, we need to perform cointsCount*(sum+1) operations to calc each cache item;
// So, Time Complexity is O(cointsCount*sum).

// We create additional cache array with coinsCount*(sum+1) size.
// Plus we still have some recursive calls with memory allocated in stack.
// In worst case, stack height is (coinsCount-1)+sum;
// So, total Auxiliary Space = O(coinsCount*sum) + O(coinsCount+sum) => O(coinsCount*sum)

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
