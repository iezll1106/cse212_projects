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
        // PLAN:
        // 1. Create a new array of size 'length'.
        // 2. Use a for loop to fill each element with the correct multiple.
        //    Like: result[0] = number * 1, result[1] = number * 2, ...
        // 3. Return the filled array.

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1); // Compute the (i+1)th multiple of number
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
        // PLAN:
        // 1. Find the slice of the list that needs to move to the front.
        //    That slice starts from (data.Count - amount) to the end.
        // 2. Get the remaining part (from beginning up to that index).
        // 3. Clear the list.
        // 4. Add the rotated part first, then the remaining part.

        int n = data.Count;

        // Get the last 'amount' elements
        List<int> endSlice = data.GetRange(n - amount, amount);

        // Get the first 'n - amount' elements
        List<int> startSlice = data.GetRange(0, n - amount);

        // Clear the original list and add the slices in rotated order
        data.Clear();
        data.AddRange(endSlice);
        data.AddRange(startSlice);
    }
}
