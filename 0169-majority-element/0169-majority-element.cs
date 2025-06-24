public class Solution {
    public int MajorityElement(int[] nums) {
    
    var values = nums.GroupBy(x => x);
                var maxValue = values.MaxBy(g => g.Count());
                return maxValue.Key;
    }
}