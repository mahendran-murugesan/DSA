namespace DSA;

public class ThreeNumberSum
{
    public List<int[]> GetNumbers(int[] array, int targetSum)
    {
        int leftPointer, rightPointer, numberToFind;
        List<int[]> result = new List<int[]>();
        Array.Sort(array);
        for(int i=0; i<array.Length; i++)
        {
            leftPointer = i+1;
            rightPointer = array.Length - 1;
            numberToFind = targetSum - array[i];
            while(leftPointer<rightPointer)
            {
                int sum = array[leftPointer] + array[rightPointer];
                if(numberToFind == sum)
                {
                    result.Add(new int[]{array[i], array[leftPointer], array[rightPointer]});
                    leftPointer++;
                    rightPointer--;
                }
                if(numberToFind > sum)
                {
                    leftPointer++;
                }
                if(numberToFind < sum)
                {
                    rightPointer--;
                }
            }
        }
        return result;
    }
}