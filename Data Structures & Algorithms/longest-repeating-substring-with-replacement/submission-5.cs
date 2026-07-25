public class Solution 
{
    public int CharacterReplacement(string s, int k) 
    {
        int res=0;
        for(int i=0;i<s.Length;i++)
        {
            int max=0;
            Dictionary<char,int> d=new Dictionary<char,int>();
            for(int y=i;y<s.Length;y++)
            {
                if(!d.ContainsKey(s[y]))
                    d[s[y]]=1;
                else
                    d[s[y]]++;
                max=Math.Max(max,d[s[y]]);
                if((y-i+1)-max<=k)
                    res=Math.Max(res,y-i+1);
            }
        }
        return res;
   }
}
