using DSA.Trees;

namespace DSA;

public class ClosesetValueinBST
{
    public static int FindClosestValueInBst(BST tree, int target)
    {
        var currentNode = tree;
        var smallestDifference = int.MaxValue;
        var closestValue = 0;
        while (currentNode != null)
        {
            var currentDifference = Math.Abs(currentNode.value - target);
            if (currentDifference < smallestDifference)
            {
                smallestDifference = currentDifference;
                closestValue = currentNode.value;
            }

            if (currentNode.value > target)
            {
                currentNode = currentNode.left;
            }
            else if (currentNode.value < target)
            {
                currentNode = currentNode.right;
            }
        }

        return closestValue;
    }
}

