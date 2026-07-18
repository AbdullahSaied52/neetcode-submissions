public class Solution {
    public int LongestConsecutive(int[] nums) {
        SortedSet<int> list1=new SortedSet<int>(nums);
        List<int>list=new List<int>(list1);
        List<int>res=new List<int>();
        int c;
        if(nums.Length==0)
            c=0;
        else
            c=1;
        for(int i=1;i<list.Count;i++)
        {
            if(list[i]==list[i-1]+1)
                c++;
            else
            {
                res.Add(c);
                c=1;
            }
            res.Add(c);
        }
        res.Add(c);
        return res.Max();
    }
}
