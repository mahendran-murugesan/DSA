namespace DSA;

public class SmallestChange
{
    public int NonConstructibleChange(int[] coins)
    {
        Array.Sort(coins);

        var change = 0;
        foreach (var coin in coins)
        {
            if (coin > change + 1)
            {
                return change + 1;
            }

            change += coin;
        }

        return change + 1;
    }
}