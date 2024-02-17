Here is a Python console application that calculates the number of islands in a 2D grid map. An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.

```python
class Solution:
    def numIslands(self, grid):
        if not grid:
            return 0
            
        count = 0
        for i in range(len(grid)):
            for j in range(len(grid[0])):
                if grid[i][j] == '1':
                    self.dfs(grid, i, j)
                    count += 1
        return count

    def dfs(self, grid, i, j):
        if(i<0 or j<0 or i>=len(grid) or j>=len(grid[0]) or grid[i][j] != '1'):
            return
        grid[i][j] = '#'
        self.dfs(grid, i+1, j)
        self.dfs(grid, i-1, j)
        self.dfs(grid, i, j+1)
        self.dfs(grid, i, j-1)

grid_map = [
  ['1','1','1','1','0'],
  ['1','1','0','1','0'],
  ['1','1','0','0','0'],
  ['0','0','0','0','0']
]

s = Solution()
print(s.numIslands(grid_map))
```

In this code, we first initialize a count to 0. We then iterate over each cell in the grid. If the cell is land (represented by '1'), we increment our count and then sink the island. To sink the island, we use a depth-first search (DFS) approach where we recursively check all adjacent cells. If an adjacent cell is also land, we recursively sink that island as well. This continues until we have visited all cells in the island, effectively sinking it. We then continue to the next cell in the grid. The final count gives us the number of islands in the grid.