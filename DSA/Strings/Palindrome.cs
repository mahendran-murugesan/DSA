namespace DSA.Strings;

public class Palindrome
{
    public static bool IsPalindrome(string str)
    {
        var result = false;

        var palindromeString = string.Empty;

        for (int i = str.Length-1; i >= 0; i--)
        {
           // var t = str[i];
            palindromeString = palindromeString + str[i];
        }

        if (str == palindromeString)
        {
            result = true;
        }

        return result;
    }
}