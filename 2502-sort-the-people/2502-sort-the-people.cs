public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
     
        var sortedPeople = names
            .Select((name, index) => new { Name = name, Height = heights[index] })
            .OrderByDescending(person => person.Height)  
            .Select(person => person.Name)  
            .ToArray(); 

        return sortedPeople;
    }
}
