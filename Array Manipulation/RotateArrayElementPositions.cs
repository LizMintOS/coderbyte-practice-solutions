int[] ints = RotateArray([1,2,3,4,5], 2);

foreach(int i in ints)
{
    Console.WriteLine(i);
}

Console.ReadLine(); 

static int[] RotateArray(int[] nums, int k)
{
    int arrTotal = nums.Length;
    k = k % arrTotal;

    if (k == 0) return [];

    int[] temp = new int[arrTotal];

    for (int i = 0; i < arrTotal; i++)
    {
        temp[(i + k) % arrTotal] = nums[i];
    }

    Array.Copy(temp, nums, arrTotal);
    return nums;
}

// OR (more efficient)

//int n = nums.Length;
//k = k % n; // In case k is larger than the array length
//Array.Reverse(nums, 0, n); // Reverse entire array
//Array.Reverse(nums, 0, k); // Reverse first k elements
//Array.Reverse(nums, k, n - k); // Reverse the remaining elements