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
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode result = new();
        ListNode cur = result;
        ListNode? a, b;
        a = l1;
        b = l2;
        int o = 0;
        while (a != null || b!= null) {
            cur.val = (a?.val ?? 0) + (b?.val ?? 0) + o;
            o = cur.val/10;
            cur.val %= 10;
            a = a?.next;
            b = b?.next;
            if(b == null && a == null) 
            {
                if(o > 0)
                {
                     cur.next = new()
                        {
                            val = o
                        };
                }
                break;
            }
            cur.next = new();
            cur = cur.next;
        }
        return result;
    }
}