public class Solution {
    public int[] NumberGame(int[] nums) {
        Array.Sort(nums);
        List<int> result = new List<int>();
    
        for(int i = 0; i < nums.Length;i++){
            for(int j = i+1; j < nums.Length; j++){
               result.Add(nums[j]);
               result.Add(nums[i]);
                 i+=1;
                 break;
            }

        }
          
    return result.ToArray();
    }
}