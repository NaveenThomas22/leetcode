public class Solution {
    public int MostWordsFound(string[] sentences) {
    
     List<int> Value = new List<int>();
     for(int i = 0; i < sentences.Length; i++){
        int words = sentences[i].Split(' ').Length;
        Value.Add(words);
     }
    return Value.Max();
    }
}