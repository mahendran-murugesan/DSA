using System.Collections.Generic;
namespace DSA.Arrays;

public class MissingNumbersProgram
{
    public int[] MissingNumbers(int[] nums)
    {
        var length = nums.Length + 2;

        var array = new List<int>();

        for (int i = 0; i < length; i++)
        {
            array.Add(i+1);
        }

        var result = array.Except(nums);

        return result.ToArray();
    }
}