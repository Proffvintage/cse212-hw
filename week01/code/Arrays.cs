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
        // Create the requested number of entries.  The value at index i is
        // number multiplied by its one-based position in the sequence.
        var multiples = new double[length];
        for (var i = 0; i < length; i++)
            multiples[i] = number * (i + 1);

        return multiples;
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
        // Preserve the final 'amount' values, remove them from their old
        // positions, and insert them at the beginning in the same order.
        var start = data.Count - amount;
        var moved = data.GetRange(start, amount);
        data.RemoveRange(start, amount);
        data.InsertRange(0, moved);
    }
}
