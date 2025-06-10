    public class Solution {
        public int[] RunningSum(int[] nums) {
        List<int> values = new List<int>();
        values.Add(nums[0]);
        for(int i = 1 ; i < nums.Length; i++){
            values.Add(nums[i] + values[i-1]);
        }
        return values.ToArray();
    }
}