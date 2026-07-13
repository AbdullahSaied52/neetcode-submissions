public class Solution 
{
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        Dictionary<string, List<String>> dict = new Dictionary<string, List<string>>();

        foreach(var x in strs)
        {
            int [] count=new int[26];
            foreach(var s in x)
            {
                count[s-'a']++;
            }
            string key=string.Join(",",count);
            if(!dict.ContainsKey(key))
            {
                dict[key]=new List<string>();
            }
            dict[key].Add(x);
        }

        return dict.Values.ToList<List<string>>();
    }
}
