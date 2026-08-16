
public class WordDictionary 
{
    private List<string> list;

    public WordDictionary() 
    {
        list=new List<string>();  
    }
    
    public void AddWord(string word) 
    {
        list.Add(word);
    }
    
    public bool Search(string word) 
    {
        foreach(var w in list)
        {
            if(w.Length!= word.Length) continue;
            int i=0;
            while(i<word.Length)
            {
                if(w[i]==word[i] || word[i]=='.')
                    i++;
                else
                    break;
            }
            if(i==word.Length)
                return true;
        }
        return false;
    }
}
