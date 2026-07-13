public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        List<int>list=new List<int>(nums);
        int[] result=new int[2];
        for(int i=0;i<nums.Length;i++)
        {
            if(list.Contains(target-nums[i]))
            {
                result[1]=i;
                result[0]=list.IndexOf(target-nums[i]);
            }
        }
        return result;
    }
}
