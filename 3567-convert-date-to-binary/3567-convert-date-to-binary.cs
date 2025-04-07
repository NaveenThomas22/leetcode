public class Solution {
    public string ConvertDateToBinary(string date) {

    DateTime num = DateTime.Parse(date);
    int day = num.Day;
    int month = num.Month;
    int year = num.Year;
    string  binar = Convert.ToString(day,2);
    string bina = Convert.ToString(month,2);
    string bi = Convert.ToString(year,2);
    string binary =  bi+"-"+ bina+"-"+binar;
    Console.WriteLine(binary);
    return binary;       
    }
}