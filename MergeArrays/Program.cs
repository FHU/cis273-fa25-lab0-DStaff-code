namespace MergeArrays;

public class Program
{
    public static void Main(string[] args)
    {
        int[] array1 = { 1, 3, 4, 9 };
        int[] array2 = { 2, 5, 6, 7, 9 };

        int[] merged = MergeSortedArrays(array1, array2);

        Console.WriteLine("{" + string.Join(",", merged) + "}");
    }

    // TODO 
    public static int[] MergeSortedArrays(int[] array1, int[] array2)
    {
        int i = 0, j = 0, k = 0;
        int[] result = new int[array1.Length + array2.Length];

        while (i < array1.Length && j < array2.Length)
        {
            if (array1[i] <= array2[j])
            {
                result[k++] = array1[i++];
            }
            else
            {
                result[k++] = array2[j++];
            }
        }

        while (i < array1.Length)
        {
            result[k++] = array1[i++];
        }

        while (j < array2.Length)
        {
            result[k++] = array2[j++];
        }

        return result;
    }

    // TODO 
    private static bool IsSorted(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[i - 1])
                return false;
        }
        return true;
    }
}


