using System;

public static class ArraySelector
{
    public static void Run()
    {
        // Sample int arrays and selector
        var l1 = new int[] { 1, 2, 3, 4, 5 };
        var l2 = new int[] { 2, 4, 6, 8, 10 };
        var select = new int[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1 };

        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // Output: {1, 2, 3, 2, 4, 4, 6, 8, 10, 5}

        // Sample char arrays and selector
        var c1 = new char[] { 'A', 'A', 'A', 'A', 'A' };
        var c2 = new char[] { 'B', 'B', 'B', 'B', 'B' };
        var cSelect = new int[] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2 };

        var charResult = ListSelector(c1, c2, cSelect);
        Console.WriteLine("<char[]>{" + string.Join(", ", charResult) + "}"); // Output: {A, B, A, B, A, B, A, B, A, B}
    }

    // Generic method that works with int[], char[], etc.
    private static T[] ListSelector<T>(T[] list1, T[] list2, int[] select)
    {
        T[] result = new T[select.Length];
        int i1 = 0, i2 = 0;

        for (int i = 0; i < select.Length; i++)
        {
            if (select[i] == 1)
            {
                // Check if list1 still has elements
                if (i1 >= list1.Length)
                {
                    Console.WriteLine("Not enough items in the first list.");
                    return new T[0]; // Return empty array
                }
                result[i] = list1[i1++];
            }
            else if (select[i] == 2)
            {
                // Check if list2 still has elements
                if (i2 >= list2.Length)
                {
                    Console.WriteLine("Not enough items in the second list.");
                    return new T[0]; // Return empty array
                }
                result[i] = list2[i2++];
            }
            else
            {
                // Selector contains invalid value
                Console.WriteLine("Selector must contain only 1s and 2s.");
                return new T[0]; // Return empty array
            }
        }

        return result;
    }
}