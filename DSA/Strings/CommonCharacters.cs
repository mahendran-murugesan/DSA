namespace DSA.Strings;

public class CommonCharactersProgram
{
    public static string[] CommonCharacters(string[] strings)
    {
        var input = strings.ToList();
        var stringDictionary = new Dictionary<char, int>();
        foreach (var s in input)
        {
            var unique = new HashSet<char>(s);

            foreach (var c in unique)
            {
                if (stringDictionary.ContainsKey(c))
                {
                    stringDictionary[c] = stringDictionary[c] + 1;
                }
                else
                {
                    stringDictionary.Add(c, 1);
                }
            }
        }

        List<string> result = stringDictionary.Where(x => x.Value == strings.Length).Select(x => x.Key.ToString()).ToList();
        return result.ToArray();

    }
}