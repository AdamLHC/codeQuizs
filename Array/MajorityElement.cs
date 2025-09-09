namespace Array;

public static class MajorityElement
{
    public static int solve(int[] nums)
    {
        if (nums.Count() < 1)
        {
            return 0;
        }

        var lookup = new Dictionary<int, int>();
        var majorElement = nums[0];
        foreach (var num in nums)
        {
            if (!lookup.TryAdd(num, 1))
            {
                lookup[num]++;
            }

            if (lookup[num] > lookup[majorElement])
            {
                majorElement = num;
            }
        }

        return majorElement;
    }

    public static int solveByMooreMajority(int[] nums) //Moore majority vote algorithm
    {
        int candidate = nums[0];
        int count = 0;

        foreach (var num in nums)
        {
            if (count == 0) candidate = num;
            count += (candidate == num) ? 1 : -1;
            // if (res == num)
            // {
            //     count++;
            //     continue;
            // }

            // if (count > 0)
            // {
            //     count--;
            //     continue;
            // }

            // if (count <= 0)
            // {
            //     res = num;
            //     continue;
            // }
        }
        return candidate;
    }

}