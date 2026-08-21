/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) 
    {
        if(node==null) return null;
        var dic=new Dictionary<Node,Node>();
        var q=new Queue<Node>();
        dic[node]=new Node(node.val);
        q.Enqueue(node);
        while(q.Count>0)
        {
            var cur=q.Dequeue();
            foreach(var n in cur.neighbors)
            {
                if(!dic.ContainsKey(n))
                {
                    dic[n]=new Node(n.val);
                    q.Enqueue(n);
                }
                dic[cur].neighbors.Add(dic[n]);
            }
        }
        return dic[node];
        
    }
}
