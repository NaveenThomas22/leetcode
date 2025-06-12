public class Solution {
    public int MaximumNumberOfStringPairs(string[] words) {
        int count = 0;
        for(int i =  0 ; i < words.Length; i++){
            for(int j =i + 1; j < words.Length; j++){
              var arr = words[j].ToCharArray();
              Array.Reverse(arr);
              string reversed = new string(arr);
              Console.WriteLine(reversed);
              if(words[i] == reversed){
                count ++;
              }
            }
        }
        return count ;
    } 
}