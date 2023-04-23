namespace DSA.Strings;

public class GroupAnagrams
{
    public static List<List<string>> groupAnagrams(List<string> words)
    {
        var memo = new Dictionary<string, List<string>>();
        var result = new List<List<string>>();

        foreach (var word in words)
        {
            var sortedString = string.Concat(word.OrderBy(c => c));

            if (memo.ContainsKey(sortedString))
            {
                memo[sortedString].Add(word);
            }
            else
            {
                memo[sortedString] = new List<string>() { word };
            }
        }

        return memo.Values.ToList();
    }
}