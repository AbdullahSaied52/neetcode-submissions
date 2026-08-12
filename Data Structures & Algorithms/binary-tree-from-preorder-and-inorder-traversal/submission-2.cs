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

public class Solution 
{
    int preidx=0;
    int inidx=0;
    public TreeNode BuildTree(int[] preorder, int[] inorder) 
    {
        return dfs(preorder ,inorder,int.MaxValue);
        
    }
    private TreeNode dfs(int[] preorder, int[] inorder,int limit)
    {
        if(preidx>=preorder.Length) return null;
        if(inorder[inidx]==limit)
        {
            inidx++;
            return null;
        }
        TreeNode root=new TreeNode(preorder[preidx++]);
        root.left=dfs(preorder,inorder,root.val);
        root.right=dfs(preorder,inorder,limit);
        return root;
    }
}
