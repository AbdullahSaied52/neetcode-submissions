public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int>hash1=new HashSet<int>();
        hash1=nums.ToHashSet();
        if(hash1.Count()<nums.Count())
            return true;
        return false;
    }
}