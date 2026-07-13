public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] result=new int[2];
        for(int i=0;i<nums.Length;i++)
        {
            for (int y=i+1;y<nums.Length;y++)
            {
                if(nums[i]+nums[y]==target)
                {
                    return [i,y];
                }
            }
        }
        return result;
    }
}
