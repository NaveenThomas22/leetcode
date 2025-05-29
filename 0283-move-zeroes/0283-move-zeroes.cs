public class Solution {
    public void MoveZeroes(int[] nums) {
     int insertVal = 0;
      for(int i =0; i < nums.Length;i++){
        if(nums[i] != 0){
            nums[insertVal] = nums[i];
            insertVal++;
        }

      }
      while(insertVal < nums.Length){
        nums[insertVal]=0;
        insertVal++;
      }
    }
}