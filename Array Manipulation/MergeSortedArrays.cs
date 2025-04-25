int[] ints = MergeSortedArrays([1, 4, 8], [2, 6, 9]);
foreach(int i in ints)
{
    Console.WriteLine(i);
}
Console.ReadLine();

static int[] MergeSortedArrays(int[] arr1, int[] arr2)
{
    int[] sortedArray = [.. arr1, .. arr2];
    Array.Sort(sortedArray);
    return sortedArray;
}