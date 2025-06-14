public class Solution {
    public int[] SeparateDigits(int[] nums) {
        List<int> addNums = new List<int>();

        for (int i = 0; i < nums.Length; i++) {
            string strNum = nums[i].ToString();
            for (int j = 0; j < strNum.Length; j++) {
                int digit = strNum[j] - '0';      
                addNums.Add(digit);               
            }
        }

        return addNums.ToArray();              
    }
}
