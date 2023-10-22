class CoinChangeRecursive
{
    public int MinCoins(int[] coins, int sum)
   {
       var minCount = MinCoins(coins, coins.Length - 1, sum);

       if (minCount >= int.MaxValue - 1) return -1;

       return minCount;
   }

    private int MinCoins(int[] coins, int n, int sum)
    {
        // Base case: if sum equals 0, then no coins are required
        if (sum == 0) return 0;

        // If sum is negative or no coins are left, then it is impossible to make sum
        if (sum < 0 || n < 0) return int.MaxValue - 1;

        int withCoin = 1 + MinCoins(coins, n, sum - coins[n]); // use (int.MaxValue - 1) as default to avoid int overflow here
        int withoutCoin = MinCoins(coins, n - 1, sum);

        return Math.Min(withCoin, withoutCoin);
    }
}

public static void Main(string[] args)
{
    int[] coins = { 1, 2, 5 };
    int sum = 11;

    int minCoins = new CoinChangeRecursive().MinCoins(coins, sum);

    if (minCoins == -1)
        Console.WriteLine("Не можливо скласти суму " + sum + " монетами.");
    else
        Console.WriteLine("Мінімальна кількість монет для суми " + sum + " гривень: " + minCoins);
}

// See RecursionTree.jpg for understanding and
// https://www.geeksforgeeks.org/perfect-binary-tree
// Time Complexity O(2^(cointsCount+sum)); Finite geometric progression; Exponential time;
// Auxiliary Space Complexity O(cointsCount+sum);
// Input Space Complexity O(coinsCount);
// Space Complexity O(coinsCount+sum);

// There is another recursion solution:
// https://www.enjoyalgorithms.com/blog/minimum-coin-change
// https://www.geeksforgeeks.org/find-minimum-number-of-coins-that-make-a-change/
// Time Complexity O(cointsCount^sum); Finite geometric progression; Exponential time;

// Such difference in algorithms complexity is because of different amount of repetitive subpromlems.