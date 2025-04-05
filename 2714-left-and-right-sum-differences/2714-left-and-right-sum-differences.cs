public class Solution {
    public int[] LeftRightDifference(int[] nums) {
        int n = nums.Length;
        int[] result = new int[n];

        for(int i = 0; i < n ; i++){
           int  leftSum = 0;
           int  rightSum = 0;

            for (int l = 0;l < i;l++){
                leftSum += nums[l];
            }

            for(int r = i+1; r <n;r++){
                rightSum += nums[r];
            }

            result[i] = Math.Abs(leftSum - rightSum);
        }
            return result;
    }
}