/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Codec {


    // Encodes a tree to a single string.
    public string Serialize(TreeNode root) 
    {
        List<string> list=new List<string>();
        dfs(root,list);
        return String.Join(",",list);

    }
    private void dfs(TreeNode root,List<string>list)
    {
        if(root==null) 
        {
            list.Add("#");
            return;
        }
        else
        {
            list.Add(root.val.ToString());
        }
        dfs(root.left,list);
        dfs(root.right,list);
    }
    // Decodes your encoded data to tree.
    public TreeNode Deserialize(string data) 
    {
        int i=0;
        string[] val=data.Split(',');
        return dfsdesrialize(val , ref i);
    }
    private TreeNode dfsdesrialize(string[] data ,ref int i)
    {
        if(data[i]=="#")
        {
            i++;
            return null;
        }
        TreeNode node=new TreeNode(Int32.Parse(data[i]));
        i++;
        node.left=dfsdesrialize(data,ref i);
        node.right=dfsdesrialize(data,ref i);
        return node;
    }
}
