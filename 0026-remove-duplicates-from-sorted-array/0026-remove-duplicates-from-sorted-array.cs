public class Solution {
    public int RemoveDuplicates(int[] nums) {

        int pos = 1;
        for(int i = 1; i < nums.Length;i++){
            if(nums[pos-1] != nums[i]){
                nums[pos] = nums[i];
                pos++;
            }
        }
        return pos;
    }
}