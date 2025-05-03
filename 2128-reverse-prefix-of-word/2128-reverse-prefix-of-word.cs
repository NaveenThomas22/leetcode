public class Solution {
    public string ReversePrefix(string word, char ch) {
        int ind = word.IndexOf(ch);
        char[] arr  = word.Substring(0,ind+1).ToCharArray();
         Array.Reverse(arr);
        string reversed = new string(arr);
        string notRev = word.Substring(ind+1);
        var result = reversed+notRev;
        if(ind == -1){
            return word;
        }else{
            return result.Trim();
        }
    
        

    }

}