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

        // DFS traversal;
        // sum => like a node in the recursion tree;
        // sum is traversed in pre-order manner;
        // But the result of MinCoins, we get in post-order manner as we need first traverse "withCoin" and "withoutCoin" subtrees first to do Math.Min(withCoin, withoutCoin);
        // https://www.enjoyalgorithms.com/blog/binary-tree-traversals-preorder-inorder-postorder
        // https://www.geeksforgeeks.org/dfs-traversal-of-a-tree-using-recursion/

        int withCoin = 1 + MinCoins(coins, n, sum - coins[n]); // use (int.MaxValue - 1) as default to avoid int overflow here;
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

// Time Complexity consists of worst-case total number of recursive calls (recursive tree nodes)
// Auxiliary Space is defined by the deepest recursive tree branch

// Another explanation of recursive time complexity
// https://www.codingninjas.com/studio/library/recursion-backtracking-time-complexity
// https://www.youtube.com/watch?v=pfiQ_PS1g8E&list=PLot-Xpze53lf5C3HSjCnyFghlW0G1HHXo 8:50 about recursive func time complexity
// Time Complexity O(2^n) + O(2^sum) => O(2^(n+sum)), where 2 number of times the func calls itself and n+sum call stack height.
