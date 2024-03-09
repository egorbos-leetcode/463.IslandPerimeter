namespace Solution;

public static class Solution
{
    public static int IslandPerimeter(int[][] grid)
    {
        var visited = new bool[grid.Length][];
        for (var i = 0; i < visited.Length; i++)
        {
            visited[i] = new bool[grid[i].Length];
        }

        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[0].Length; j++)
            {
                if (visited[i][j] == true)
                {
                    continue;
                }

                if (grid[i][j] == 1)
                {
                    return CheckPerimeter(i, j, grid, visited);
                }

                visited[i][j] = true;
            }
        }

        return 0;
    }

    public static int CheckPerimeter(int n, int m, int[][] grid, bool[][] visited)
    {
        if (n < 0 || n >= grid.Length || m < 0 || m >= grid[0].Length || visited[n][m] == true)
        {
            return 0;
        }

        visited[n][m] = true;

        var perimeter = 0;

        if (grid[n][m] == 1)
        {
            // check neighbors
            perimeter += 4;

            if (m - 1 >= 0 && grid[n][m - 1] == 1) perimeter -= 1;
            if (m + 1 < grid[n].Length && grid[n][m + 1] == 1) perimeter -= 1;
            if (n - 1 >= 0 && grid[n - 1][m] == 1) perimeter -= 1;
            if (n + 1 < grid.Length && grid[n + 1][m] == 1) perimeter -= 1;

            var left = CheckPerimeter(n, m - 1, grid, visited);
            var right = CheckPerimeter(n, m + 1, grid, visited);
            var up = CheckPerimeter(n - 1, m, grid, visited);
            var down = CheckPerimeter(n + 1, m, grid, visited);

            perimeter += left + right + up + down;
        }        

        return perimeter;
    }
}