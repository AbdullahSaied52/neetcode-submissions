public class Solution 
{
    public List<List<int>> ThreeSum(int[] nums) 
    {
        List<List<int>> res=new List<List<int>>();
        HashSet<Tuple<int, int, int>> h=new HashSet<Tuple<int, int, int>>();
        Array.Sort(nums);
        for(int i=0;i<nums.Length;i++)
            for(int y=i+1;y<nums.Length;y++)
                for(int z=y+1;z<nums.Length;z++)
                    if(nums[i]+nums[y]+nums[z]==0)
                    {
                        var triplet = Tuple.Create(nums[i], nums[y], nums[z]);
                        h.Add(triplet);
                    }
    foreach (var triplet in h) {
            res.Add(new List<int> { triplet.Item1, triplet.Item2, triplet.Item3 });
        }
        return res;
    }
}

