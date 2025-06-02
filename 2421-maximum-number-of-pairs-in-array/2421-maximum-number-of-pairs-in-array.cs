public class Solution {
    public int[] NumberOfPairs(int[] nums) {
        int[] freq = new int[101];  
        int pairs = 0;
        int leftover = 0;


        for(int i = 0; i < nums.Length; i++) {
            freq[nums[i]]++;
        }


        for(int i = 0; i < freq.Length; i++) {
            pairs += freq[i] / 2;
            leftover += freq[i] % 2;
        }

        return new int[] { pairs, leftover };
    }
}
