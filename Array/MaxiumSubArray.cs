public static class MaxiumSubarray
{
    //Kadane’s Algorithm
    // local maximum at index i is the maximum of sum_of_subarray_to_index[i] and the sum of sum_of_subarray_to_index[i] and local maximum at index i-1.
    public static int MaxSubArray(int[] nums)
    {
        int cumulative = 0;
        int max = int.MinValue;
        foreach (var num in nums)
        {
            //If adding new element causes current output to be smaller than local maxium of current element, The current local maxium is the new element.
            cumulative = Math.Max(cumulative + num, num);
            max = Math.Max(max, cumulative);
        }
        return max;
    }


    private static int max(int a, int b) { return (a > b) ? a : b; }
    private static int max(int a, int b, int c)
    {
        return max(max(a, b), c);
    }

    private static int CaculateMaxSubArraySums(int[] nums, int low, int mid, int hi)
    {
        int sum = 0;

        //left side
        int leftSum = int.MinValue;
        for (int i = mid; i >= low; i--)
        {
            sum += nums[i];
            leftSum = max(sum, leftSum);
        }

        //right side
        sum = 0;
        int rightSum = int.MinValue;
        for (int i = mid; i <= hi; i++)
        {
            sum += nums[i];
            rightSum = max(sum, rightSum);
        }

        return max(leftSum, rightSum, leftSum + rightSum - nums[mid]);
    }

    private static int DivideArray(int[] nums, int low, int hi)
    {
        //Guard: invalid range
        if (low > hi)
        {
            return int.MinValue;
        }

        //Guard: single element
        if (low == hi)
        {
            return nums[low];
        }

        int mid = low + (hi - low) / 2;
        return max(DivideArray(nums, low, mid), DivideArray(nums, mid + 1, hi), CaculateMaxSubArraySums(nums, low, mid, hi));
    }

    public static int MaxSubArrayDivideAndConqure(int[] nums)
    {
        return DivideArray(nums, 0, nums.Length - 1);
    }
}