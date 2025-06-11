public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
        List<int> oneArr = new List<int>();
        List<int> values = new List<int>();

        oneArr.AddRange(grid.SelectMany(x => x));


        int repeated = oneArr
            .GroupBy(x => x)
            .Where(g => g.Count() > 1)
            .Select(g => g.Key)
            .FirstOrDefault(); 


        HashSet<int> set = new HashSet<int>(oneArr);
        int n = oneArr.Count;

        int missing = -1;
        for (int i = 1; i <= n; i++) {
            if (!set.Contains(i)) {
                missing = i;
                break;
            }
        }

        values.Add(repeated);
        values.Add(missing);

        return values.ToArray();
    }
}
