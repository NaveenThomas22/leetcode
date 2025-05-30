 public class Solution {
 public int TotalMoney(int n) {
    int start = 0;
    int j = 0;
    int sum = 0;
    for(int i = 0; i < n; i++){
        if(i % 7 == 0){
            start ++;
            j = 0;
        }
        sum = sum+start+j;
        j++;
    } 
    return sum;
}
}