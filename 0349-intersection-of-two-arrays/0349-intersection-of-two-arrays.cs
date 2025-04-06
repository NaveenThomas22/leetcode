public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
         var common = nums1.Intersect(nums2).ToArray();
         return common;
         

    }
}