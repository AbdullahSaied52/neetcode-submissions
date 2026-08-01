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
        //if(list.Count==0)return null;
        list.Sort();
        ListNode head;
        ListNode sort= new ListNode(0);
        head=sort;
        foreach(var x in list)
        {
            head.next=new ListNode(x);
            head=head.next;
        }
        return sort.next;
    }
}
