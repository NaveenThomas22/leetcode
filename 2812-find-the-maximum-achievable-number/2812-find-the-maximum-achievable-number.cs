public class Solution {
    public int TheMaximumAchievableX(int num, int t) {
        
        var value = num + t;
        var result = value+t;
        var ans = result - 1;
        return result;

    }
}