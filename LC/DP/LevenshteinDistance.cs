namespace LC.DP;

public class LevenshteinDistance
{
    public int Difference(string original, string actual)
    {
        var board = new int[original.Length + 1, actual.Length + 1];

        for (int i = 0; i < board.GetLength(0); i++)
        {
            board[i, 0] = i;
        }

        for (int i = 0; i < board.GetLength(1); i++)
        {
            board[0, i] = i;
        }

        for (int i = 1; i < board.GetLength(0); i++)
        {
            for (int j = 1; j < board.GetLength(1); j++)
            {
                board[i, j] = System.Math.Min(board[i - 1, j] + 1, board[i, j - 1] + 1);
                var isSame = original[i - 1] == actual[j - 1];
                board[i, j] = System.Math.Min(board[i, j], board[i - 1, j - 1] + (isSame ? 0 : 1));
            }
        }

        return board[original.Length, actual.Length];
    }
}