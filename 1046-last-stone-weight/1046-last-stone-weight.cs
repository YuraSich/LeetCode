public class Solution {
    public int LastStoneWeight(int[] stones) {
        var queue = new PriorityQueue<int, int>();
        foreach (var stone in stones)
        {
            queue.Enqueue(stone, -stone);
        }
        int a, b;
        while (queue.Count > 1)
        {
            a = queue.Dequeue();
            b = queue.Dequeue();
            if (a > b) queue.Enqueue(a - b, -(a - b));
            if (a < b) queue.Enqueue(b - a, -(b - a));
        }

        return queue.Count > 0 ? queue.Peek() :0;
    }
}