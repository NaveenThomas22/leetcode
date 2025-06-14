public class Solution {
    public int FindPeakElement(int[] nums) {

    int [] sortedNums = (int[])nums.Clone();
    Array.Sort(sortedNums);
    int last = sortedNums[sortedNums.Length-1];

    // int ind = Array.IndexOf(nums,last);

    for(int i =0; i < nums.Length; i++){
        if(nums[i] == last){
            return i;
        }
    }
    return -1;
    }
}