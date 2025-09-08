namespace Strings;

public static class LongestPalindrome
{
    public static int Solve(string input)
    {
        var lookup = new Dictionary<char, int>();
        foreach (var c in input)
        {
            if (!lookup.TryAdd(c, 1))
            {
                lookup[c] += 1;
            }
        }

        var hasSingle = false;
        var count = 0;
        foreach (var letterCount in lookup)
        {
            if (letterCount.Value % 2 == 1 || letterCount.Value == 1)
            {
                hasSingle = true;
                count += letterCount.Value - 1;
            }
            else
            {
                count += letterCount.Value;
            }
        }

        if (hasSingle)
        {
            count += 1;
        }

        return count;
    }
}