public class RansomNote
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        int[] letters = new int[26];
        foreach (char letter in magazine)
        {
            letters[letter - 'a']++;
        }

        foreach (var noteLetter in ransomNote)
        {
            letters[noteLetter - 'a']--;
            if (letters[noteLetter - 'a'] < 0)
            {
                return false;
            }
        }
        return true;
    }
}