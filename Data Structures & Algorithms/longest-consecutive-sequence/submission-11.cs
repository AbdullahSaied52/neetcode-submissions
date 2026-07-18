public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
        HashSet<int>h=new HashSet<int>(nums);
        int longest=0;

        foreach(int x in h)
        {
            if(!h.Contains(x-1))
            {   
                int len=1;
                int num=x;
                while(h.Contains(num+1))
                {
                    len++;
                    num++;
                }
                longest=Math.Max(len,longest);
            }
        }
        return longest ;
    }
}
