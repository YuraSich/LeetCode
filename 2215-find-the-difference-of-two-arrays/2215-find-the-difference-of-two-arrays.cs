public class Solution {
    // Returns the elements in the first arg nums1 that don't exist in the second arg nums2.
    public List<int> GetElementsOnlyInFirstList(int[] nums1, int[] nums2) {
        HashSet<int> onlyInNums1 = new HashSet<int>(); 
        
        // Store nums2 elements in an unordered set. 
        HashSet<int> existsInNums2 = new HashSet<int>(); 
        foreach (int num in nums2) {
            existsInNums2.Add(num);
        }
        
        // Iterate over each element in the list nums1.
        foreach (int num in nums1) {
            if (!existsInNums2.Contains(num)) {
                onlyInNums1.Add(num);
            }
        }
        
        // Convert to list.
        return onlyInNums1.ToList();
    }
    
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        return new List<IList<int>> { GetElementsOnlyInFirstList(nums1, nums2), GetElementsOnlyInFirstList(nums2, nums1) };
    }
}