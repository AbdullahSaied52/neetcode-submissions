public class Solution {
    public int FindMin(int[] nums) 
    {
        int l=0;
        int r=nums.Length-1;
        
        bool min =false;
        int temp=nums[0];
        while(l<=r)
        {
            if(nums[l]<nums[r])
            {
                temp=Math.Min(temp,nums[l]);
                break;
            }
            int mid =(r+l)/2;
            temp=Math.Min(nums[mid],temp);
            if(nums[mid]>=nums[l])
                l=mid+1;
            else
                r=mid-1;

        }
        return temp;
    }
}
