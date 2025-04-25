int[] nums = { 1, 2, 3, 4, 5, 6, 7, 100, 52, 60 };
int[] twoNums = TwoSum(nums, 20);
foreach (int i in twoNums)
{
    Console.WriteLine(i);
}
Console.ReadLine();

static int[] TwoSum(int[] nums, int idealSum)
{
    int[] twoNums = new int[2];
    for (int i = 0; i < nums.Length; i++)
    {
        int difference = idealSum - nums[i];
        if (nums.Contains(difference))
        {
            twoNums[0] = difference;
            twoNums[1] = nums[i];
            break;
        }
    }
    
    return twoNums;
}