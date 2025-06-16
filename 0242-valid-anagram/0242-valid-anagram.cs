public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        string sorted_s = string.Concat(t.OrderBy(c => c));
        string sorted_t = string.Concat(s.OrderBy(y => y));
       
       return sorted_s == sorted_t;
    }
}