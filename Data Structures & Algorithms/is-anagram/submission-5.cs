public class Solution {
    public bool IsAnagram(string s, string t)
    {
        List<char>l1=new List<char>(s);
        List<char>l2=new List<char>(t);
        l1.Sort();
        l2.Sort();
        if(l1.Count()<l2.Count()||l1.Count()>l2.Count())
            return false;
        for(int i=0;i<l1.Count();i++)
        {
            if(l1[i]!=l2[i])
                return false;
        }
        return true;
    }
}
