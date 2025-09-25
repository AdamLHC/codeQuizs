public class FindDuplicate
{
    public bool ContainsDuplicate(int[] nums)
    {
        var lookup = new HashSet<int>();

        foreach (var num in nums)
        {
            if (lookup.Contains(num))
            {
                return true;
            }
            else
            {
                lookup.Add(num);
            }
        }

        return false;
    }
}