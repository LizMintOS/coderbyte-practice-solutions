Console.WriteLine(ContainsDuplicate([1, 2, 3, 4]));
Console.WriteLine(ContainsDuplicateHash([1, 2, 3, 4]));
Console.ReadKey();
static bool ContainsDuplicate(int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = 0;  j < nums.Length; j++)
        {
            if (i == j) break;
            if (nums[i] == nums[j]) return true;
        }
    }
    return false;
}

//OR 

static bool ContainsDuplicateHash(int[] nums)
{
    HashSet<int> duplicateNums = new HashSet<int>();

    foreach(int i in nums)
    {
        if (!duplicateNums.Add(i)) return true;
    }
    return false;
}