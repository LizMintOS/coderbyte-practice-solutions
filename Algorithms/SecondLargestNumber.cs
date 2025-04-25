//Not the most efficient, but the quickest I could come up with in <3 mins.
Console.WriteLine(FindSecondLargest([10, 10, 9]));
Console.ReadLine();

static int FindSecondLargest(int[] nums)
{
    if (nums.Length < 2) return -1;

    int largestNum = nums.Max();

    for(int i = 0;  i < nums.Length; i++)
    {
        if (nums[i] == largestNum) nums[i] = -1;
    }

    int secondLargestNum = nums.Max();

    return secondLargestNum;
}