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
    public ListNode SwapPairs(ListNode head) {
        // If the list is empty or has only one node, return it
        if (head == null || head.next == null) {
            return head;
        }
        
        // Initialize pointers to keep track of the nodes to swap
        ListNode prev = null;
        ListNode curr = head;
        ListNode next = head.next;
        
        // Iterate through the list and swap every two adjacent nodes
        while (curr != null && curr.next != null) {
            // Swap the nodes
            curr.next = next.next;
            next.next = curr;
            if (prev != null) {
                prev.next = next;
            } else {
                head = next;
            }
            
            // Move the pointers to the next two nodes to swap
            prev = curr;
            curr = curr.next;
            if (curr != null) {
                next = curr.next;
            }
        }
        
        // Return the new head of the list
        return head;
    }
}