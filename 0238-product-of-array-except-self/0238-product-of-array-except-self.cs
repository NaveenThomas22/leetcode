public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int product = 1;
        int zeroCount = 0;

        foreach (int num in nums) {
            if (num == 0) {
                zeroCount++;
                continue;
            }
            product *= num;
        }

        List<int> result = new List<int>();

        foreach (int num in nums) {
            if (zeroCount > 1) {
                
                result.Add(0);
            }
            else if (zeroCount == 1) {
               
                result.Add(num == 0 ? product : 0);
            }
            else {

                result.Add(product / num);
            }
        }

        return result.ToArray();
    }
}
