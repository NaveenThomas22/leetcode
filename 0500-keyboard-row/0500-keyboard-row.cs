public class Solution
{
    public string[] FindWords(string[] words)
    {
        Dictionary<string, char[]> dict = new Dictionary<string, char[]>
        {
            { "A", new char[]{ 'q','w','e','r','t','y','u','i','o','p' } }, // Row 1
            { "B", new char[]{ 'a','s','d','f','g','h','j','k','l' } },     // Row 2
            { "C", new char[]{ 'z','x','c','v','b','n','m' } }              // Row 3
        };

        List<string> values = new List<string>();

        foreach (string word in words)
        {
            string lowerWord = word.ToLower();

            if (BelongsToRow(lowerWord, dict["A"]) || BelongsToRow(lowerWord, dict["B"]) || BelongsToRow(lowerWord, dict["C"]))
            {
                values.Add(word);
            }
        }

        return values.ToArray();
    }

    private bool BelongsToRow(string word, char[] rowChars)
    {
        foreach (char c in word)
        {
            if (!rowChars.Contains(c))
                return false;
        }
        return true;
    }
}
