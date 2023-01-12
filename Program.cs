int countWays(int X, int Y)
{
    int[,] dp = new int[X + 1, Y + 1];
    dp[0, 0] = 1;
    for (int i = 0; i <= X; i++)
    {
        for (int j = 0; j <= Y; j++)
        {
            if (i >= 1)
            {
                dp[i, j] += dp[i - 1, j];
            }
            if (j >= 1)
            {
                dp[i, j] += dp[i, j - 1];
            }
            if (i >= 3 && j >= 1)
            {
                dp[i, j] -= dp[i - 3, j - 1];
            }
            if (i >= 1 && j >= 3)
            {
                dp[i, j] -= dp[i - 1, j - 3];
            }
        }
    }
    return dp[X, Y];
}


Console.WriteLine(countWays(0, 0));
Console.WriteLine(countWays(0, 7));
Console.WriteLine(countWays(1, 1));
Console.WriteLine(countWays(2, 2));
Console.WriteLine(countWays(3, 3));
Console.WriteLine(countWays(10, 2));