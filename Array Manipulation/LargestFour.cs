Console.WriteLine(LargestFour([1, 10, 14, 8, 2]));
Console.ReadLine();

static int LargestFour(int[] arr)
{
    if (arr.Length <= 0) return 0;

    int sum = 0;
    if (arr.Length <= 4)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }

    Array.Sort(arr);

    int[] largestFourElements = { arr[arr.Length - 4], arr[arr.Length - 3], arr[arr.Length - 2], arr[arr.Length - 1] };

    for (int i = 0; i < largestFourElements.Length; i++)
    {
        sum += largestFourElements[i];
    }
    return sum;
}