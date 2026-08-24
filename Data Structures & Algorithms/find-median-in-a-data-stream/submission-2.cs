public class MedianFinder 
{
    List<int> list;
    public MedianFinder() 
    {
        list=new List<int>();
    }
    
    public void AddNum(int num) 
    {

        list.Add(num);
        list.Sort();
        
    }
    
    public double FindMedian() 
    {
        int c=list.Count;

        if(c%2==0)
        {
            return((list[c/2]+list[(c/2)-1])/2.0);
        }   
        else
        {
            return list[c/2];
        }
    }
}
