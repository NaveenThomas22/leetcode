public class Solution {
    public bool CanAliceWin(int[] nums) {
        int single = 0;
        int doubleSum = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] <=9){
                single += nums[i];
            }else{
                doubleSum += nums[i];
            }
        }
        return single != doubleSum;
    }
} 