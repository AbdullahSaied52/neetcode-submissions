public class Solution 
{
    public int MaxArea(int[] heights) 
    {
        List<int>list=new List<int>();
        for(int i=0;i<heights.Length;i++)
        {
            for(int y=i+1;y<heights.Length;y++)
            {
                if(heights[i]<heights[y])
                    list.Add(heights[i]*(y-i));
                else
                    list.Add(heights[y]*(y-i));
            }
        }
        return list.Max();
    }
}
