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
    public bool IsValidBST(TreeNode root) 
    {
        return valid(root,long.MinValue,long.MaxValue);
    }
    public bool valid(TreeNode node,long left,long right)
    {
        if (node == null) 
            return true;

        if (!(left < node.val && node.val < right)) 
            return false;

        return valid(node.left, left, node.val) &&
               valid(node.right, node.val, right);
    }
        
        // if(root.left!=null &&root.right!=null)
        // {
        //     if(root.val<root.right.val &&root.val>root.left.val)
        //     {
        //         return IsValidBST(root.left) && IsValidBST(root.right);
        //     }
        //     else
        //         return false;
        // }
        // else if(root.left==null &&root.right!=null)
        // {
        //     if(root.val<root.right.val)
        //     {
        //         return   IsValidBST(root.right);
        //     }
        //     else
        //         return false;
        // }
        // else if(root.right==null &&root.left!=null)
        // {
        //     if(root.val>root.left.val)
        //     {
        //         return IsValidBST(root.left) ;
        //     }
        //     else
        //         return false;
        // }
        // else
        //     return true;
    }

