public class Solution {
    public int MaxProfit(int[] prices) 
    {
        //int i=prices.Length-1;
        //int y=0;
        //List<int>list=new List<int>{0};
        int res=0;
        for(int i=0;i<prices.Length;i++)
        {
            for(int y=i+1;y<prices.Length;y++)
            {
                if(prices[y]>prices[i]&&prices[y]-prices[i]>res)
                {
                    res=prices[y]-prices[i];
                }
            }
        }
        return res;
    }
}
