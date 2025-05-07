using System.Linq;

public class Solution {
    public int SingleNumber(int[] nums) {
        return nums.Distinct()
                   .First(num => nums.Count(x => x == num) == 1); 
    }
}