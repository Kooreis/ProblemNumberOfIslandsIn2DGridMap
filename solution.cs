Here is a C# console application that calculates the number of islands in a 2D grid map. An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. 

```C#
using System;

class Program
{
    static void Main(string[] args)
    {
        char[][] grid = new char[][]
        {
            new char[] {'1','1','1','1','0'},
            new char[] {'1','1','0','1','0'},
            new char[] {'1','1','0','0','0'},
            new char[] {'0','0','0','0','0'}
        };

        Console.WriteLine("Number of islands is: " + NumIslands(grid));
    }

    public static int NumIslands(char[][] grid)
    {
        if (grid == null || grid.Length == 0)
        {
            return 0;
        }

        int numIslands = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == '1')
                {
                    numIslands += Dfs(grid, i, j);
                }
            }
        }

        return numIslands;
    }

    public static int Dfs(char[][] grid, int i, int j)
    {
        if (i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length || grid[i][j] == '0')
        {
            return 0;
        }

        grid[i][j] = '0';
        Dfs(grid, i + 1, j);
        Dfs(grid, i - 1, j);
        Dfs(grid, i, j + 1);
        Dfs(grid, i, j - 1);
        return 1;
    }
}
```

This program uses Depth-First Search (DFS) to count the number of islands. It starts by iterating over each cell in the grid. If the cell value is '1' (land), it increments the island count and then uses DFS to mark all the connected land cells as '0' (water). This way, when it encounters the same land cell again, it won't count it as a new island.