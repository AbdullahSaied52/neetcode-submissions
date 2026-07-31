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
    public ListNode RemoveNthFromEnd(ListNode head, int n) 
    {
        List<ListNode> list=new List<ListNode>();
        ListNode temp=head;
        while(temp!=null)
        {
            list.Add(temp);
            temp=temp.next;
        }

        int len=list.Count;
        int dis=len-n; //2
        temp=head;
        head=temp;
        if(dis==0)
        {
            return head.next;
        }
        list[dis-1].next=list[dis].next;
        return head;

    }
}
