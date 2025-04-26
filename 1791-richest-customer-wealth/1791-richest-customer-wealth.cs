public class Solution {
    public int MaximumWealth(int[][] accounts) {
        List <int> nums = new List <int>();
        for(int i = 0; i < accounts.Length;i++){
          nums.Add(accounts[i].Sum());
        }
        return nums.Max();
    }
}