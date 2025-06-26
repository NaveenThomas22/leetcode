public class Solution {
    
   public int RomanToInt(string s) 
{
    Dictionary<string, int> values = new Dictionary<string, int> 
    { 
        {"I", 1},
        {"V", 5},
        {"X", 10},
        {"L", 50},
        {"C", 100},
        {"D", 500},
        {"M", 1000},
        {"IV", 4},
        {"IX", 9},
        {"XL", 40},
        {"XC", 90},
        {"CD", 400},
        {"CM", 900}
    };

    int sum = 0;

    for (int i = 0; i < s.Length;)
    {

        if (i + 1 < s.Length && values.ContainsKey(s.Substring(i, 2)))
        {
            sum += values[s.Substring(i, 2)];
            i += 2;
        }
        else
        {
            sum += values[s[i].ToString()];
            i++;
        }
    }

    return sum;
}

}