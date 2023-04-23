using System.Collections.Generic;

namespace DSA.Strings;

public class GenerateDocumentProgram
{
    public static bool GenerateDocument(string characters, string document)
    {
        var charMap = new int[128];
        foreach (var c in characters)
        {
            charMap[(int)c]++;
        }

        foreach (var c in document)
        {
            if (--charMap[(int)c] < 0)
                return false;
        }

        return true;
    }
}