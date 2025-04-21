    public class Solution {
        public int FindNumbers(int[] nums) {
            List<int> Len = new List<int>();
            int even = 0;
            for(int i =0; i < nums.Length; i++ ){
                Len.Add(nums[i].ToString().Length); 
            }
            for(int j = 0; j < Len.Count;j++){
                if(Len[j]%2==0){
                    even++;
                }
            }
            return even;
        }
    }