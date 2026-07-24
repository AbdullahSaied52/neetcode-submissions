public class Solution {
    public int LengthOfLongestSubstring(string s) 
    {
        int res=0;
        int l=0;
       HashSet<char>h=new HashSet<char>();
       for(int i=0;i<s.Length;i++)
       {
        while(h.Contains(s[i]))
        {
            h.Remove(s[l]);
            l++;
        }
        h.Add(s[i]);
        res=Math.Max(res,h.Count);
       }
        return res;
    }
}
