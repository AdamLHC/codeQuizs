public class FirstBadVerison(int badVersion)
{
    protected bool IsBadVersion(int version) => version >= badVersion;
}

public class BadVersionSolutin(int badVersion) : FirstBadVerison(badVersion)
{
    public int FirstBadVersion(int n)
    {
        int upperBound = n, lowerBound = 1;
        int index = 0;
        while (lowerBound <= upperBound)
        {
            index = (upperBound - lowerBound) / 2 + lowerBound; // Avoid interger overflow
            if (!base.IsBadVersion(index))
            {
                lowerBound = index + 1;
            }
            else
            {
                if (index == 1 || !base.IsBadVersion(index - 1))
                {
                    return index;
                }
                upperBound = index - 1;
            }
        }
        return index;
    }
}

// [ 1, 2, 3, 4, 5, 6]  4