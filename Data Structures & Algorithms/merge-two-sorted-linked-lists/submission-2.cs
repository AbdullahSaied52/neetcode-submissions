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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) 
    {
        ListNode d=new ListNode(0);
        ListNode n=d;

        if(list1==null)
            return list2;
        else if(list2==null)
            return list1;
        
        while(list1!=null && list2!= null)
        {
            if(list1.val<=list2.val)
            {
                n.next=list1;
                list1=list1.next;
            }
            else
            {
                n.next=list2;
                list2=list2.next;
            }
            n=n.next;
        }
        if(list1!=null)
            n.next=list1;
        else
            n.next=list2;

        return d.next;
        
    }
}