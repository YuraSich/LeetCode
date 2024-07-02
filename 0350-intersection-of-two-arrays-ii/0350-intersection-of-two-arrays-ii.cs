public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
       return IntersectInner(nums1, nums2).ToArray();
    }

    public IEnumerable<int> IntersectInner(int[] nums1, int[] nums2)
    {
        Array.Sort(nums1);
        Array.Sort(nums2);
        int a = 0, b = 0;
        while (a < nums1.Length && b < nums2.Length)
        {
            if (nums1[a] == nums2[b])
            {
                yield return nums1[a];
                a++;
                b++;
            }
            else if (nums1[a] > nums2[b])
            {
                b++;
            }
            else if (nums1[a] < nums2[b])
            {
                a++;
            }
        }
    }
}