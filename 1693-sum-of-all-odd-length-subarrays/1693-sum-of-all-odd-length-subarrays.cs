public class Solution {
    public int SumOddLengthSubarrays(int[] arr) {
        int totalSum = 0;

        for (int i = 0; i < arr.Length; i++) {
            for (int j = 1; i + j <= arr.Length; j += 2) {
                int[] subArray = arr.Skip(i).Take(j).ToArray();
                totalSum += subArray.Sum();
            }
        }

        return totalSum;
    }
}
