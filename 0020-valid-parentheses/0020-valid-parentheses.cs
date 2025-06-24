public class Solution {
    public bool IsValid(string s) {
     
   Dictionary<char, char> dict = new Dictionary<char, char>
{
    { ')', '(' },
    { ']', '[' },
    { '}', '{' }
};

     Stack <char> values = new Stack <char>(); 

     for(int i = 0 ; i < s.Length; i++){
         char c = s[i];
         if( c == '('|| c == '[' || c == '{'){
            values.Push(c);
         }else{
            if (values.Count == 0 || values.Pop() != dict[c]){
                return false;
            }
         }
    }
    return values.Count == 0;
    }
    
}