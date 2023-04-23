namespace DSA.Trees;

public class BST
{
    public int value;
    public BST left;
    public BST right;

    public BST(int value)
    {
        this.value = value;
    }

    public BST Insert(int value)
    {
        var currentNode = this;

        while (true)
        {
            if (value < currentNode.value)
            {
                if (currentNode.left == null)
                {
                    currentNode.left = new BST(value);
                    break;
                }
                else
                {
                    currentNode = currentNode.left;
                }
            }
            else
            {
                if (currentNode.right == null)
                {
                    currentNode.right = new BST(value);
                    break;
                }
                else
                {
                    currentNode = currentNode.right;
                }
            }
        }

        return this;
    }

    public bool Contains(int value)
    {
        var currentNode = this;
        while (currentNode != null)
        {
            if (value < currentNode.value)
            {
                currentNode = currentNode.left;
            }
            else if(value > currentNode.value)
            {
                currentNode = currentNode.right;
            }
            else
            {
                return true;
            }
        }

        return false;
    }

    public BST Remove(int value, BST parentNode = null)
    {
        var currentNode = this;
        while (currentNode != null)
        {
            if (value < currentNode.value)
            {
                parentNode = currentNode;
                currentNode = currentNode.left;
            }
            else if(value > currentNode.value)
            {
                parentNode = currentNode;
                currentNode = currentNode.right;
            }
            else
            {
                if (currentNode.left != null && currentNode.right != null)
                {
                    currentNode.value = currentNode.right.GetMinValue();
                    currentNode.right.Remove(currentNode.value, currentNode);
                }
                else if (parentNode == null)
                {
                    if (currentNode.left != null)
                    {
                        currentNode.value = currentNode.left.value;
                        currentNode.right = currentNode.left.right;
                        currentNode.left = currentNode.left.left;
                    }
                    else if (currentNode.right != null)
                    {
                        currentNode.value = currentNode.right.value;
                        currentNode.right = currentNode.right.right;
                        currentNode.left = currentNode.right.left;
                    }
                    else
                    {
                     //   
                    }
                }
                else if (parentNode.left == currentNode)
                {
                    parentNode.left = currentNode.left ?? currentNode.right;
                }
                else if (parentNode.right == currentNode)
                {
                    parentNode.right = currentNode.left ?? currentNode.right;
                }
                break;
            }
        }
        return this;
    }

    public int GetMinValue()
    {
        return left?.GetMinValue() ?? value;
    }
}


