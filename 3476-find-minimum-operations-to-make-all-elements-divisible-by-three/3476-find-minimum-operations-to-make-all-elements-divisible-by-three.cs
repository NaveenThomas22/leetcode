public class Solution {
    public int MinimumOperations(int[] nums) {
        int operations = 0;

        foreach (int num in nums) {
            int remainder = num % 3;
            if (remainder == 1 || remainder == 2) {
                operations += 1;
            }
        }

        return operations;
    }
}
