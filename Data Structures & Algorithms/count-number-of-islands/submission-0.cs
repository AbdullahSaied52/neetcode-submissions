public class Solution 
{
    int rows,colms;
    public int NumIslands(char[][] grid) 
    {
        int count=0;
        rows=grid.Length;
        colms=grid[0].Length;

        for(int r=0;r<grid.Length;r++)
        {
            for(int c=0;c<grid[0].Length;c++)
            {
                if(grid[r][c]=='1')
                {
                    count++;
                    dfs(grid,r,c);
                }
            }
        }
        return count;
    }

    private void dfs( char[][] grid, int r,int c)
    {
        
        if(  r<rows &&c<colms &&r>=0&&c>=0 &&  grid[r][c]=='1')
        {
            grid[r][c]='0';
            dfs(grid,r+1,c);
            dfs(grid,r-1,c);
            dfs(grid,r,c+1);
            dfs(grid,r,c-1);
        }
        else
            return;
    }
}
