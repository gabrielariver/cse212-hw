public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        
        // Do not allow duplicates
        if (value == Data)
        {
            return; // Don't insert if the value already exists
        }

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        
        // If we found the value, return true
        if (value == Data)
        {
            return true;
        }
        
        // If the value is less, search in the left subtree
        if (value < Data)
        {
            if (Left is null)
                return false; // Doesn't exist
            else
                return Left.Contains(value); // Search recursively
        }
        
        // If the value is greater, search in the right subtree
        else
        {
            if (Right is null)
                return false; // Doesn't exist
            else
                return Right.Contains(value); // Search recursively
        }
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        
        // Height of the left subtree (0 if it doesn't exist)
        int leftHeight = (Left is null) ? 0 : Left.GetHeight();
        
        // Height of the right subtree (0 if it doesn't exist)
        int rightHeight = (Right is null) ? 0 : Right.GetHeight();
        
        // The height of the current node is 1 + the maximum height of its subtrees
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}