public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int>hash1=new HashSet<int>();
        foreach(int x in nums)
        {
            if(!hash1.Add(x))
                return true;
        }
        return false;
    }
}