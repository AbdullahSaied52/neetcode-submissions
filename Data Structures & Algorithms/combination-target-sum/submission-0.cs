public class Solution 
{
    List<List<int>> list;
    public List<List<int>> CombinationSum(int[] nums, int target) 
    {
        list=new List<List<int>>();
        Array.Sort(nums);
        dfs(0,new List<int>(),0, nums, target);
        return list;
    }

    private void dfs(int i,List<int> cur,int total,int [] nums,int target)
    {
        if(total==target)
            {
                list.Add(new List<int>(cur));
                return;
            }
        for(int j=i;j<nums.Length;j++)
        {
            if(total +nums[j]>target )return ;
            cur.Add(nums[j]);
            dfs(j,cur,total+nums[j],nums,target);
            cur.RemoveAt(cur.Count-1);
        }
    }

}
