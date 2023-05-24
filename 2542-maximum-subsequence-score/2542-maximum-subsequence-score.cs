public class Solution {
    public long MaxScore(int[] nums1, int[] nums2, int k) {
        // Sort pair (nums1[i], nums2[i]) by nums2[i] in decreasing order.
        int n = nums1.Length;
        int[][] pairs = new int[n][];
        for (int i = 0; i < n; ++i) {
            pairs[i] = new int[]{nums1[i], nums2[i]};
        }
        Array.Sort(pairs, (a, b) => b[1] - a[1]);
        
        // Use a min-heap to maintain the top k elements.
        PriorityQueue<int, int> topKHeap = new PriorityQueue<int, int>(k, Comparer<int>.Create((a, b) => a - b));
        long topKSum = 0;
        for (int i = 0; i < k; ++i) {
            topKSum += pairs[i][0];
            topKHeap.Enqueue(pairs[i][0], pairs[i][0]);
        }
        
        // The score of the first k pairs.
        long answer = topKSum *pairs[k - 1][1];
        
        // Iterate over every nums2[i] as minimum from nums2.
        for (int i = k; i < n; ++i) {
            // Remove the smallest integer from the previous top k elements
            // then add nums1[i] to the top k elements.
            topKSum += pairs[i][0] - topKHeap.Dequeue();
            topKHeap.Enqueue(pairs[i][0], pairs[i][0]);
            
            // Update answer as the maximum score.
            answer = Math.Max(answer, topKSum * pairs[i][1]);
        }
        
        return answer;
    }
}