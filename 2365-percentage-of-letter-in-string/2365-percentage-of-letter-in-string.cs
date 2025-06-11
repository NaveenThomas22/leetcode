public class Solution {
    public int PercentageLetter(string s, char letter) {
        
        int count = 0;

        for(int i = 0; i < s.Length;i++){
        if(s[i] == letter){
            count++;
        }     
        }
        double rtrnVal = ((double)count/s.Length) * 100;

        Console.WriteLine(rtrnVal);

return (int)rtrnVal;
    }
}