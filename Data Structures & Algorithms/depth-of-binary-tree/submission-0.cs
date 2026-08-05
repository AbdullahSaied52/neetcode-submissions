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

public class Solution {
    public int MaxDepth(TreeNode root) 
    {
        int rig;
        int lef;
        if(root!= null)
        {   
            lef=MaxDepth(root.left)+1;
            rig=MaxDepth(root.right)+1;
        }
        else
            return 0;

        return Math.Max(lef,rig);

    }
}
