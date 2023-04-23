using System.Text;

namespace DSA.Strings;

public class RunLengthEncodingProgram
{
    public static string RunLengthEncoding(string str)
    {
        var sb = new StringBuilder();
        char symbol = str[0];
        int count = 0;
        foreach (var c in str)
        {
            if (count == 9 || symbol != c)
            {
                sb.Append(count);
                sb.Append(symbol);
                count = 1;
                symbol = c;
            }else if (symbol == c)
            {
                count++;
            }
        }

        sb.Append(count);
        sb.Append(symbol);

        return sb.ToString();
    }
}