Console.WriteLine(IterativeBinarySearch([1, 2, 4, 8, 20, 28], 2));
Console.ReadLine();

static int IterativeBinarySearch(int[] arr, int target)
{
    int minIdx = 0;
    int maxIdx = arr.Length - 1;

    while (minIdx <= maxIdx)
    {
        int middle = (minIdx + maxIdx) / 2;
        if (target == arr[middle]) return middle++;
        else if (target < arr[middle]) maxIdx = middle - 1;
        else minIdx = middle + 1;
    }

    return -1;
}