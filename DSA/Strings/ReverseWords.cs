using System.Security.Cryptography.X509Certificates;

namespace DSA.Strings;

public class ReverseWords
{
    public static string ReverseWordsInString(string str)
    {
        string output = string.Empty;

        var words = str.Split(" ");

        for (int i = words.Length - 1; i >= 0; i--)
        {
            if (string.IsNullOrEmpty(output))
            {
                output += words[i];
            }
            else
            {
                output += " " + words[i];
            }
            
        }

        return output;

    }
}