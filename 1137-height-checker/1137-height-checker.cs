public class Solution {
    public int HeightChecker(int[] heights) {

        int[] arr = (int[])heights.Clone();
        Array.Sort(arr); 
        int count = 0;
        for(int i = 0; i < heights.Length;i++){
            if(arr[i] != heights[i]){
                count++;
            }
        }
     return count;
    }

}