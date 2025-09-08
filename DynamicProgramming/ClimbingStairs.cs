namespace DynamicProgramming;

public static class ClimbingStair
{
    public static int ClimbStairs(int n)
    {
        var lookup = new int[n + 1];
        lookup[0] = lookup[1] = 1;

        for (int i = 2; i <= n; i++)
        {
            lookup[i] = lookup[i - 1] + lookup[i - 2];
        }
        return lookup[n];
    }

    public static int CLimbFaster(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        int current = 0;
        int previousOne = 1, previousTwo = 1;
        for (int i = 2; i <= n; i++)
        {
            current = previousOne + previousTwo;
            previousTwo = previousOne;
            previousOne = current;
        }
        return current;
    }

    // Over time limit
    private static int climb(int current, int step, int target)
    {
        if (current + step > target)
        {
            return 0;
        }

        if (current + step == target)
        {
            return 1;
        }

        current += step;

        return climb(current, 1, target) + climb(current, 2, target);
    }
}