public class Solution {
    public int HammingWeight(int n) {

        int count = 0;

        string num = Convert.ToString(n,2);

        for(int i = 0; i < num.Length;i++ ){
            if(num[i] == '1'){
                count++;   
             }
        }
        Console.WriteLine(count);
        return count;
        
    }
}