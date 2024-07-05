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
    public int[] NodesBetweenCriticalPoints(ListNode head) {
    int firstIndex = -1;
	int prevIndex = -1;
	int lastIndex = -1;
	var prevNode = head;
	var currNode = head.next;
	var currIndex = 1;
	var min = -1;
	while (currNode.next != null)
	{
		if (IsCritical(currNode, prevNode))
		{
			if (firstIndex == -1)
			{
				firstIndex = currIndex;
			}
			else
			{
				if (prevIndex == -1)
				{
					min = currIndex - firstIndex;
					prevIndex = currIndex;
				}
				else
				{
					if (min > currIndex - prevIndex)
					{
						min = currIndex - prevIndex;
					}
					prevIndex = currIndex;
				}
			}
			lastIndex = currIndex;
		}
		prevNode = currNode;
		currNode = currNode.next;
		currIndex++;
	}
	if (firstIndex == -1 || firstIndex == lastIndex) return new[] { -1, -1 };
	var rs = new[] { min, lastIndex - firstIndex };
	return rs;
    }
    
    private bool IsCritical(ListNode currNode, ListNode prevNode)
    {
        if (prevNode.val > currNode.val && currNode.val < currNode.next.val) return true;
        if (prevNode.val < currNode.val && currNode.val > currNode.next.val) return true;
        return false;
    }
}