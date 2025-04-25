Console.WriteLine(FindMissingNumber([]));
Console.ReadLine();
static int FindMissingNumber(int[] nums)
{
    int n = nums.Length + 1;
    int expectedSum = n * (n + 1) / 2;
    int actualSum = nums.Sum();
    return expectedSum - actualSum;
}