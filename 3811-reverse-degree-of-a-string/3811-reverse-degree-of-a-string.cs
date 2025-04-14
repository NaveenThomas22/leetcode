public class Solution {
    public int ReverseDegree(string s) {
        List <int> result = new List<int>();  
    
        for(int i = 0; i < s.Length; i++){

         int reversedIndex = 122- (int)s[i]+1; 
         int index =i +1;
         result.Add(reversedIndex * index);
        }
        
        Console.WriteLine(string.Join(",", result));
        return result.Sum();    
    }
}