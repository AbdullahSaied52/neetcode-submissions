/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution 
{    
    public ListNode MergeKLists(ListNode[] lists) 
    {
        List<int>list=new List<int>();
        ListNode temp;
        for(int i=0;i<lists.Length;i++)
        {
            temp=lists[i];
            while(temp!=null)
            {
                list.Add(temp.val);
                temp=temp.next;
            }

        }
        if(list.Count==0)return null;
        ListNode head;
        List<ListNode>sort=new List<ListNode>();
        foreach(var x in list.OrderBy(n=>n))
        {
            sort.Add(new ListNode(x));
        }
        for(int i=0;i<sort.Count-1;i++)
        {
            sort[i].next=sort[i+1];
        }
        
        head=sort[0];
        return head;
    }
}
