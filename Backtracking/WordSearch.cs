public class Solution {
    public bool Exist(char[][] board, string word) {
        // https://leetcode.com/problems/word-search/description/?envType=list&envId=ob9rj7ig
        
        // https://www.youtube.com/watch?v=QiBlZzLpJqA
        // https://leetcode.com/problems/word-search/solutions/2439953/python-faster-than-98-w-proof-easy-to-understand/?envType=list&envId=ob9rj7ig
        // https://www.youtube.com/watch?v=pfiQ_PS1g8E&list=PLot-Xpze53lf5C3HSjCnyFghlW0G1HHXo

        if (!PruneSearch(board, word)) return false;

        // Local functions in C# above 7 (local functions vs lambda expressions)
        // Func and Action (types of delegates)
        // delegate keyword (also for anonimus functions)

        int rows = board.Length;
        int cols = board[0].Length;

        bool Dfs(int r, int c, int i)
        {
            if (i == word.Length) return true;

            if (r < 0 || r >= rows || c < 0 || c >= cols || word[i] != board[r][c]) return false;

            var temp = board[r][c];

            board[r][c] = '#'; // to exclude the cell to be used again

            var result = Dfs(r, c - 1, i + 1) || Dfs(r + 1, c, i + 1) || Dfs(r, c + 1, i + 1) || Dfs(r - 1, c, i + 1);

            board[r][c] = temp; // backtrack

            return result;
        }

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                if (Dfs(r, c, 0)) return true;
            }
        }

        return false;

        // Time Complexity O(m*n*4^l)
        // Auxiliary Space O(l) // stack height
    }

    private bool PruneSearch(char[][] board, string word)
    {
        var boardChars = new Dictionary<char, int>();

        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                if (boardChars.ContainsKey(board[i][j]))
                {
                    boardChars[board[i][j]] += 1;
                }
                else
                {
                    boardChars.Add(board[i][j], 1);
                }
            }
        }

        var wordChars = new Dictionary<char, int>();

        foreach (char c in word)
        {
            if (wordChars.ContainsKey(c))
            {
                wordChars[c] += 1;
            }
            else
            {
                wordChars.Add(c, 1);
            }
        }

        foreach(KeyValuePair<char, int> wc in wordChars)
        {
            if (boardChars.TryGetValue(wc.Key, out var boardCount))
            {
                if (boardCount < wc.Value) return false;
            }
            else
            {
                return false;
            }
        }

        return true;

        // Time complexity O(m*n + l)
        // Auxiliary space O(1); => We have two extra dictionaries => max number of keys is limited to quantity of alphabet characters
    }
}
