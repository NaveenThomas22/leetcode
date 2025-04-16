public class Solution
{
    public int[] FindIntersectionValues(int[] nums1, int[] nums2)
    {
        int value = 0;
        int value2 = 0;

        for (int i = 0; i < nums1.Length; i++)
        {
            for (int j = 0; j < nums2.Length; j++)
            {
                if (nums1[i] == nums2[j])
                {

                    value += 1;
                    break;
                }
            }
        }

         for (int k = 0; k < nums2.Length; k++)
        {
            for (int m = 0; m < nums1.Length; m++)
            {
                if (nums2[k] == nums1[m]){

                    value2 += 1;
                    break;
                }
            }
        }
        return new int[] {value,value2};
    }
}
