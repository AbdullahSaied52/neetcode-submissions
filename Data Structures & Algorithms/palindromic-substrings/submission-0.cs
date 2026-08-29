public class Solution {
    public int CountSubstrings(string s) 
    {
        int count=0;
        for(int i=0;i<s.Length;i++)
        {
            for(int y=i;y<s.Length;y++)
            {
                int l=i,r=y;
                while(l<r && s[l]==s[r])
                {
                    l++;
                    r--;
                }
                if(l>=r)
                    count++;
            }
        }
        return count;
    }
}
