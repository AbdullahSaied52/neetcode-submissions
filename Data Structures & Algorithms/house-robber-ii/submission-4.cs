public class Solution {
    public int Rob(int[] nums) 
    {
        if(nums.Length==1)
            return nums[0];
        else if(nums.Length==0) 
            return 0;
        
        return Math.Max(help(nums[1..]),help(nums[..^1]));
    }

    private int help(int[] nums)
    {

        int rob1=0,rob2=0;
        foreach(int x in nums)
        {
            int temp=Math.Max(x+rob1,rob2);
            rob1=rob2;
            rob2=temp;
        }

        return rob2;
    }
}
