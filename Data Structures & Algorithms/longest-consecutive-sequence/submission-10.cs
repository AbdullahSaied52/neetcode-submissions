public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
        HashSet<int>h=new HashSet<int>(nums);
        int longest=0;

        foreach(int x in h)
        {
            int len=0;
            int num=x;
            while(h.Contains(num))
            {
                len++;
                num++;
            }
            longest=Math.Max(len,longest);

        }
        return longest ;
    }
}
