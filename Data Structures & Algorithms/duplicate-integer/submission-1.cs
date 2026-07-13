public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int>hash1=new HashSet<int>();
        hash1=nums.ToHashSet();
        return hash1.Count()<nums.Length;
    }
}