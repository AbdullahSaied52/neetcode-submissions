public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
        int [] res=new int[k];
        Dictionary<int,int> dict=new Dictionary<int,int>();
        foreach(var x in nums)
        {
            if(!dict.ContainsKey(x))
            {
                dict[x]=1;
            }
            else
            {
                dict[x]++;
            }
        }
        // Dictionary<int,int>dict2=new Dictionary<int,int>();
        // foreach(var x2 in dict)
        // {
        //     dict2.Add(x2.Value,x2.Key);
        // }
        int n=0;

        foreach(var x3 in dict.OrderByDescending(n=>n.Value))
        {
            
            if(k>0)
            {
                res[n]=x3.Key;        
                k--;
                n++;
            }
        }
        return res;
    }
}
