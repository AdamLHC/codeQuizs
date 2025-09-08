public static class IsAnagramSolution
{
    public static bool IsAnagram(string s, string t)
    {
        var input = CountWords(s);
        var compare = CountWords(t);

        return CountWords(s).OrderBy(t => t.Key).SequenceEqual(CountWords(t).OrderBy(s => s.Key));
    }

    private static Dictionary<char, int> CountWords(string input)
    {
        var dict = new Dictionary<char, int>();
        foreach (var c in input.ToCharArray())
        {
            if (dict.ContainsKey(c)) { dict[c]++; }
            else { dict[c] = 1; }
        }
        return dict;
    }

    public static bool IsAnagramImproved(string s, string t)
    {
        if (s.Length != t.Length) { return false; }

        int[] dict = new int[26];

        for (int i = 0; i < s.Length; i++)
        {
            dict[s[i] - 'a']++;
            dict[t[i] - 'a']--;
        }

        foreach (var count in dict)
        {
            if (count != 0) { return false; }
        }
        return true;
    }
}