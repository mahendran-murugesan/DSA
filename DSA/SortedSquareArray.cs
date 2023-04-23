namespace DSA;

public class SortedSquareArray
{
    public int[] SquareArray(int[] array)
    {
        int[] resultArray = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            resultArray[i] = array[i] * array[i];
        }

        Array.Sort(resultArray);
        return resultArray;
    }
}