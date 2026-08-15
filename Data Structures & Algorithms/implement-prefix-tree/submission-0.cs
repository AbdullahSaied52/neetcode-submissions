public class TrieNode
{
    public Dictionary<char,TrieNode> child=new
    Dictionary<char,TrieNode>();
    public bool end=false;
}

public class PrefixTree 
{
    private TrieNode root;

    public PrefixTree() 
    {
        root=new TrieNode();
    }
    
    public void Insert(string word) 
    {
        TrieNode cur=root;
        foreach(var x in word)
        {
            if(!cur.child.ContainsKey(x))
                cur.child[x]=new TrieNode();
            cur=cur.child[x];
        }
        cur.end=true;
    }
    
    public bool Search(string word) 
    {
        TrieNode cur=root;
        foreach(var x in word)
        {
            if(!cur.child.ContainsKey(x))
                return false;
            cur=cur.child[x];
        }
        return cur.end;
    }
    
    public bool StartsWith(string prefix) 
    {
        TrieNode cur =root;
        foreach(var x in prefix)
        {
            if(!cur.child.ContainsKey(x))
                return false;
            cur=cur.child[x];
        }
        return true;
        
    }
}
