namespace Dsa;

// https://app.codility.com/programmers/trainings/7/countries_count/
public class CodilityCountriesCount
{
    // r = number of rows
    // c = number of columns
    // Time complexity: O(r * c) -> each cell is visited only once
    // Space complexity: O(r * c) -> each visited cell + call stack
    public static int Count(int[][] A)
    {
        var visited = new bool[A.Length,A[0].Length];
        var count = 0;

        int dfs(int r, int c)
        {
            var key = $"{r}:{c}";

            if (visited[r,c] == true)
            {
                return 0;
            }

            visited[r, c] = true;
            var current = A[r][c];

            if (c < A[0].Length - 1 && A[r][c+1] == current) //can move right and is same country
            {
                dfs(r, c + 1);
            }
            if (r < A.Length - 1 && A[r+1][c] == current) //can move down and is same country
            {
                dfs(r + 1, c);
            }
            if (c >= 1 && A[r][c - 1] == current) //can move left and is same country
            {
                dfs(r, c - 1);
            }
            if (r >= 1 && A[r - 1][c] == current) //can move up and is same country
            {
                dfs(r - 1, c);
            }

            return 1;
        }

        for (int i = 0; i < A.Length; i++)
        {
            for (int j = 0; j < A[0].Length; j++)
            {
                count += dfs(i, j);
            }
        }

        return count;
    }
}