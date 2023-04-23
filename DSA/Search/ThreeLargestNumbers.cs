namespace DSA.Search;

public class ThreeLargestNumbers
{
    public static int[] FindThreeLargestNumbers(int[] array)
    {
        var output = new List<int>();
        
        Array.Sort(array);

        for (int i = array.Length-1; i >= 0; i--)
        {
            if (output.Count < 3)
            {
                output.Add(array[i]);
            }
            
        }

        output.Sort();
        
        return output.ToArray();
    }
}