public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // 1. Create an array of size 'length'.
        // 2.  Traverse i from 0 to length-1.
        // 3. At each position i, store (i+1) * number.
        //Return the resulting array.
        // Complexity: Time O(length); Space O(length) times the output array.

        var result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = (i + 1) * number;
        }
        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // 1) If the list is empty, exit.
        // 2) Normalize shift: k = quantity % n (if k==0, no shift).
        // 3) Use the 3-way reversal technique (in-place, O(1) space):
        //      a) Reverse the entire list.
        //      b) Reverse the prefix of length k.
        //      c) Reverse the remaining suffix.
        // 4) Complexity: O(n) time. O(1) additional space.

        int n = data.Count;
        if (n == 0) return;
        int k = amount % n;
        if (k == 0) return;
        data.Reverse(0, n);
        data.Reverse(0, k);
        data.Reverse(k, n - k);
    }
}
