public class Solution {
    public string LongestPalindrome(string s) 
    {
        string res="";
        int reslen=0;
        
        for(int i =0;i<s.Length;i++)
        {
            for(int y=i;y<s.Length;y++)
            {
                int l=i,r=y;
                while(l<r && s[l]==s[r])
                {
                    l++;
                    r--;
                }
                if(l>=r && reslen<(y-i+1))
                {
                    res=s.Substring(i,y-i+1);
                    reslen=y-i+1;
                }
            }
        }
        return res;
    }


}
