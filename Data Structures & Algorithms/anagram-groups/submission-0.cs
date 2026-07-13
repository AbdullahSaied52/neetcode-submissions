public class Solution 
{
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        Dictionary<string, List<String>> dict = new Dictionary<string, List<string>>();

        for(int i=0;i<strs.Length;i++)
        {
            char[] s1 = strs[i].ToCharArray();
            Array.Sort(s1);
            string s2=new string(s1);
            if(!dict.ContainsKey(s2))
            {
                dict[s2] = new List<string>();
            }
            dict[s2].Add(strs[i]);
        }
        return dict.Values.ToList<List<string>>();
    }
}
