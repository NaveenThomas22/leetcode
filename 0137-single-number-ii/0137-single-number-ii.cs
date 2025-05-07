public class Solution {
    public int SingleNumber(int[] nums) {
        if (nums.Length == 1) return nums[0];

        Array.Sort(nums);
        int value = nums[0];
        int count = 1;

        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] == nums[i - 1]) {
                count++;
            } else {
                if (count == 1) {
                    return nums[i - 1];
                }
                value = nums[i];
                count = 1;
            }
        }
        if (count == 1) {
            return value;
        }
        return value; 
    }
}