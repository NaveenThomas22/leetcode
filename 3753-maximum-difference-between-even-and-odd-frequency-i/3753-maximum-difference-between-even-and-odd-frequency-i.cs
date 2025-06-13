public class Solution {
    public int MaxDifference(string s) {   
        var charCounts = s.GroupBy(x => x)
                          .Select(y => y.Count())
                          .ToList();

        var even = charCounts.Where(count => count % 2 == 0).ToList();
        var odd = charCounts.Where(count => count % 2 != 0).ToList();
 int maximum = int.MinValue;
         for(int i = 0 ; i < odd.Count; i++){
            for(int j = 0; j < even.Count;j++){
             maximum = Math.Max(maximum,odd[i]-even[j]);
            }
         }

        return maximum;
    }
}
