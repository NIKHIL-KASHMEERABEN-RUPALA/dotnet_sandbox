
// Path with Maximum Gold

public class Solution{


    private int findMaxGold(int[][] grid , int i , int j , int m , int n , bool[][] visited)
    {
        if(i<0 || j < 0 || i>=m || j>=n || visited[i][j] || grid[i][j]==0){
            return 0;
        }

        

    }

    public int GetMaximumGold(int[][] grid){
        if (grid==null || grid.Length==0){
            return 0;
            // coz if grid 2-d array is empty or grid 2d array has no elements then we return 0
        }

    int m = grid.Length; // represents total number of rows
    int n = grid.Length[0]; // represents total number of columns
    int max = 0;
    bool[][] visited = new bool[m][];
    for (int k = 0; k < m; k++) {
        visited[k] = new bool[n];
    }

    for(int i = 0 ; i < m ; i++)
        {
            for(int j = 0 ; j<n ; j++)
            {

                if (grid[i][j] > 0)
                {
                    int gold = findMaxGold(gridi,j,m,n,visited);
                    max = Math.Max(max,gold);
                }

            }
        }
        return max;

    }


}