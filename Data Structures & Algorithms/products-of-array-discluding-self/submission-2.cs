public class Solution 
{
    public int[] ProductExceptSelf(int[] nums) 
    {
        int result=1;
        int has_zero=0;
        int [] final=new int[nums.Length];
        foreach(var x in nums)
        {
            if(x==0)
                {
                    has_zero++;
                    if(has_zero>1)
                        {
                            result=0;
                            break;
                        }
                }
            else
                {
                    result*=x;
                }
        }
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]==0)
                final[i]=result;
            else if(has_zero>=1)
                 final[i]=0;
            else
                final[i]=result/nums[i];
        }
        return final;
    }
}
