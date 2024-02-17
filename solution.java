Here is a Java console application that calculates the number of islands in a 2D grid map:

```java
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int m = scanner.nextInt();
        int n = scanner.nextInt();
        int[][] grid = new int[m][n];
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                grid[i][j] = scanner.nextInt();
            }
        }
        System.out.println(numIslands(grid));
    }

    public static int numIslands(int[][] grid) {
        if (grid == null || grid.length == 0) {
            return 0;
        }

        int numIslands = 0;
        for (int i = 0; i < grid.length; i++) {
            for (int j = 0; j < grid[i].length; j++) {
                if (grid[i][j] == 1) {
                    numIslands += dfs(grid, i, j);
                }
            }
        }

        return numIslands;
    }

    public static int dfs(int[][] grid, int i, int j) {
        if (i < 0 || i >= grid.length || j < 0 || j >= grid[i].length || grid[i][j] == 0) {
            return 0;
        }

        grid[i][j] = 0;
        dfs(grid, i + 1, j);
        dfs(grid, i - 1, j);
        dfs(grid, i, j + 1);
        dfs(grid, i, j - 1);
        return 1;
    }
}
```

This program reads the size of the grid and the grid itself from the console. It then calculates the number of islands using a depth-first search (DFS) and prints the result. An island is defined as a group of 1's (representing land) surrounded by 0's (representing water). The DFS is used to mark the visited land cells and count the number of islands.