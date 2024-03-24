public class Solution {
    public int FindDuplicate(int[] nums) {
        int l = 1, r = nums.Length - 1; 
        
        while (l <= r) 
        {
            int eq = 0, inRange = 0;
            int mid = l + (r - l) / 2;
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == mid)
                {
                    eq++;
                    inRange++; 
                }
                else if (nums[i] < mid && nums[i] >= l)
                {
                    inRange++;
                }
            }
            if (eq > 1)
                return mid;
            else if (inRange > mid - l+1)
                r = mid - 1;
            else
                l = mid + 1; 
        }
        
        return -1;
    }
}