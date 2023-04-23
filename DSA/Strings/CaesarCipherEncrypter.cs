namespace DSA.Strings;

public class CaesarCipherEncrypter
{
    public static string CaesarCypherEncryptor(string str, int key)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        string output = "";
        foreach (char c in str)
        {
            int index = alphabet.IndexOf(c);
            index = (index + key) % 26;
            output += alphabet[index];
        }

        return output;
    }
}