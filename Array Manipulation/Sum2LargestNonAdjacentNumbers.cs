Console.WriteLine(maxSum([3, 2, 7, 10, 20]));
Console.ReadLine();

static int maxSum(int[] nums)
{
    if (nums.Length < 2) return 0;

    int count, sum, mx = nums[0], idx = 0;

    for (int i = 1; i < nums.Length; i++)
    {
        if (nums[i] > mx)
        {
            mx = nums[i];
            idx = i;
        }
    }

    if (idx == nums.Length - 1) count = 2;
    else count = 3;

    var newNums = nums.ToList();
    newNums.RemoveRange(idx - 1, count);

    int max2 = newNums.Max();

    Console.WriteLine($"{max2} + {mx}");

    sum = max2 + mx;
    return sum;
}