namespace DSA;

public class TwoNumberSum
{
    public int[] GetTwoNumber(int[] array, int targetSum)
    {
        var nums = new List<int>();
        foreach (var n in array)
        {
            var potentialMatch = targetSum - n;
            if (nums.Contains(potentialMatch))
            {
                return new int[] { potentialMatch, n };
            }
            else
            {
                nums.Add(n);
            }
        }

        return new int[0];
    }
}