public class Solution {
    public int AddedInteger(int[] nums1, int[] nums2) {
        Array.Sort(nums1);
        Array.Sort(nums2);

        for(int i = 0; i < nums1.Length;i++){
            for(int j = 0; j < nums2.Length;j++){
                int a = nums2[j] - nums1[i];
                Console.WriteLine(a);
                return a;
            }
        }
        return 0;
    }

}