public class Solution {
    public int FurthestBuilding(int[] heights, int bricks, int ladders) {
        
        var heap = new PriorityQueue<int, int>();
        
        for(int i = 0; i < heights.Length - 1; i++) 
        {
            
            int diff = heights[i + 1] - heights[i];
            
            if(diff <= 0) 
            {
                continue;
            }
            
            heap.Enqueue(diff, diff);
            
            if(heap.Count > ladders) 
            {
                var min = heap.Dequeue();
                bricks -= min;
            }
            
            if(bricks < 0) 
            {
                return i;
            }
            
        }
        
        return heights.Length - 1;
    }
}