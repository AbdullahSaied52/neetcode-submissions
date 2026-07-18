public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
        HashSet<int>h=new HashSet<int>(nums);
        int longest=1;
        if(nums.Length<1)
            longest=0;
        foreach(int x in h)
        {
            if(h.Contains(x-1))
            {
                int len=2;
                int num=x;
                while(h.Contains(num+1))
                {
                    len++;
                    num++;
                }
                if(longest<len)
                    longest=len;
            }

        }
        return longest ;
    }
}
