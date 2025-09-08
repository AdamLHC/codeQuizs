public static class CountDifferencePairs
{
    public static int CountKDifference(int[] nums, int k)
    {
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] - nums[j] == k || nums[i] - nums[j] == -1 * k)
                {
                    count++;
                }
            }
        }
        return count;
    }


    public static int CountKDifferenceImproved(int[] nums, int k)
    {
        var lookup = new Dictionary<int, uint>();
        int count = 0;

        foreach (var num in nums)
        {
            int difference = num - k;
            if (lookup.ContainsKey(difference))
            {
                count = count + (int)lookup[difference];
            }

            int negativeDifference = num + k;
            if (lookup.ContainsKey(negativeDifference))
            {
                count = count + (int)lookup[negativeDifference];
            }

            if (lookup.ContainsKey(num))
            {
                lookup[num]++;
            }
            else
            {
                lookup.Add(num, 1);
            }
        }

        return count;
    }

    public static int CountKDifferenceFaster(int[] nums, int k)
    {
        var lookup = new int[101];
        int count = 0;

        foreach (var num in nums)
        {
            if ((num - k) >= 1) { count += lookup[num - k]; }
            if ((num + k) <= 100) { count += lookup[num + k]; }
            lookup[num]++;
        }

        return count;
    }
}