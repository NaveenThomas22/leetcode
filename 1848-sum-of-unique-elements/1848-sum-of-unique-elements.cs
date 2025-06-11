public class Solution {
    public int SumOfUnique(int[] nums) {
        
        var items = nums.GroupBy(x => x)
        .Where(x => x.Count() ==  1)
        .Select(y => y.Key);
        return items.Sum();
    }
}