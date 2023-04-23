namespace DSA;

public class ValidateSubsequence
{
    public bool Validate(List<int> array, List<int> sequence)
    {
        if (sequence.Count > array.Count)
        {
            return false;
        }

        int seqIndex = 0;
        for (int i = 0; i < array.Count; i++)
        {
            if (array[i] == sequence[seqIndex])
            {
                seqIndex++;
            }

            if (seqIndex == sequence.Count)
            {
                return true;
            }
        }

        return false;
    }
}