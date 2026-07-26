public class Solution 
{
    public string MinWindow(string s, string t) 
    {
        List<string> s1=new List<string>();
        string res=s;
        for(int i=0;i<s.Length;i++)
        {
        List<char> c=new List<char>(t);

            string len="";
            int count=c.Count;
            int y=i;
            if(c.Contains(s[y]))
            {
                while(count>0&&y<s.Length)
                {
                    if(c.Contains(s[y]))
                        {
                            c.Remove(s[y]);
                            count--;
                        }
                    len+=s[y];
                    y++;
                }
                if(count==0)
                    s1.Add(len);
            }
        }
        //res=s1.Min(); //not returns the shortest but return the first in alpha pet
        res=s1.OrderBy(s=>s.Length).FirstOrDefault();
        foreach(var x in s1)
            Console.WriteLine(x);
        return s1.Min()!=null?res:"";
    }
}
