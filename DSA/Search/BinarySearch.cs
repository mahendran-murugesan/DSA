namespace DSA.Search;

public class BinarySearchProgram
{
    public static int BinarySearch(int[] array, int target)
    {
        int minNum = 0;
        int maxNum = array.Length - 1;

        while (minNum <= maxNum)
        {
            int mid = (minNum + maxNum) / 2;
            if (target == array[mid])
                return mid;
            else if (target < array[mid])
                maxNum = mid - 1;
            else
                minNum = mid + 1;
        }

        return -1;
    }
}