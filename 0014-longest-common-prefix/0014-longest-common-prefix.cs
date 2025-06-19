public class Solution {
    public string LongestCommonPrefix(string[] strs) {

        if(strs == null || strs.Length == 0)
        return "";

        StringBuilder prefix = new StringBuilder(strs[0]);
        
         for(int i = 1; i < strs.Length; i++){
            while (!strs[i].StartsWith(prefix.ToString()))
                prefix.Remove(prefix.Length -1,1); 
         }
         
         return prefix.ToString();
    }
}