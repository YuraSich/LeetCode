public class KthLargest {

    private PriorityQueue<int, int> pq = new();
    private int _k;
    
    public KthLargest(int k, int[] nums) {
        _k = k;
        foreach(var i in nums)
        {
            pq.Enqueue(i, i);
            if (pq.Count > k)
                pq.Dequeue();
        }
    }
    
    public int Add(int val) {
        pq.Enqueue(val, val);
        if (pq.Count > _k)
            pq.Dequeue();
        return pq.Peek();
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */