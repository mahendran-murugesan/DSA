namespace DSA.Strings;

public class SemordnilapProgram
{
    public static List<List<string>> Semordnilap(string[] words)
    {
        var seenWords = new List<string>();
        List<List<string>> result = new List<List<string>>();

        foreach (var word in words)
        {
            if (seenWords.Contains(new string(word.Reverse().ToArray())))
            {
                var reverseString = new string(word.Reverse().ToArray());
                result.Add(new List<string>() { word, reverseString });
            }
            else
            {
                seenWords.Add(word);
            }
        }

        return result.Distinct().ToList();

        
    }
}