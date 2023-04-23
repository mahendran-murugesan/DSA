namespace DSA.Strings;

public class FirstNonRepeatingCharacterProgram
{
    public static int FirstNonRepeatingCharacter(string str)
    {
        int lenght = str.Length;
        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];
            string sub = str.Remove(i, 1);
            if (!sub.Contains(ch))
            {
                return i;
            }
        }

        return -1;
    }
}