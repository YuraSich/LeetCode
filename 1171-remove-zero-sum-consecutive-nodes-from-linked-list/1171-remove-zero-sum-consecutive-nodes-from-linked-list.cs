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
    public ListNode RemoveZeroSumSublists(ListNode head) {
        var dict = new Dictionary<int, ListNode>();
	var stack = new Stack<int>();
	var sum = 0;

	for (var curr = head; curr != null; curr = curr.next) {
		sum += curr.val;

		if (sum == 0) {
			head = curr.next;
			dict.Clear();
		}
		else if (dict.ContainsKey(sum)) {
			dict[sum].next = curr.next;
			while (stack.Count > 0 && stack.Peek() != sum) 
				dict.Remove(stack.Pop());
		}
		else {
			dict.Add(sum, curr);
			stack.Push(sum);
		}
	}

	return head;
    }
}