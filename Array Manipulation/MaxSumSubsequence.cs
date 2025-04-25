Console.WriteLine(maxSumSubsequence([10, 5, 2, 18, 6, 24]));
Console.ReadLine();

static int maxSumSubsequence(int[] originalArray)
{
    if (originalArray.Length == 0) return 0;
    if (originalArray.Length == 1) return originalArray[0];

    int[] sums = new int[originalArray.Length];

    sums[0] = originalArray[0];
    sums[1] = Math.Max(originalArray[0], originalArray[1]);

    if (originalArray.Length == 2) return sums[1];

    for (int i = 2; i < originalArray.Length; i++)
    {
        sums[i] = Math.Max(sums[i - 1], originalArray[i] + sums[i - 2]);
    }

    return sums[originalArray.Length - 1];
}