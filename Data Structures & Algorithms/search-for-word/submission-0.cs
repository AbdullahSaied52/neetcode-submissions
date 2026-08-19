public class Solution {
private int rows,coloumns;
    public bool Exist(char[][] board, string word) 
    {
        rows=board.Length;
        coloumns =board[0].Length;
        for(int i=0;i<rows;i++)
        {
            for(int y=0;y<coloumns;y++)
            {
                if(dfs(0,board,word,i,y))
                    return true;
            }
        }
        return false;
    }

    private bool dfs(int i,char[][] board,string word,int r,int c)
    {
        if(i==word.Length)
            return true;
        if(r<0||c<0|| r>=rows||c>=coloumns||
        board[r][c]!=word[i]|| board[r][c]=='*')
            return false;
        board[r][c]='*';
        bool res=dfs(i+1,board,word,r+1,c)||
            dfs(i+1,board,word,r-1,c)||
            dfs(i+1,board,word,r,c+1)||
            dfs(i+1,board,word,r,c-1);
        board[r][c]=word[i];
        return res;
        
    }
}