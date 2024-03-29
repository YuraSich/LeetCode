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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if(head == null || head.next == null)return null;

        ListNode dummy = new ListNode(0);
        dummy.next = head;
        int count = 0;

        ListNode iterate = head;
        while(iterate != null){
            count++;
            iterate = iterate.next;
        }      
        count-=n;
        ListNode prev = dummy; 
        for (int i = 0; i < count; i++) {
            prev = prev.next;
        }
        prev.next = prev.next.next;
        return dummy.next;
    }
}