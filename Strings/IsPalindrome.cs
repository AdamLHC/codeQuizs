public class IsPalindrome
{
    public static bool Run(string s)
    {
        char[] alphaBetOnlyInput = s.ToLowerInvariant().Where(char.IsLetterOrDigit).ToArray();

        // bool isPalindrome = true;

        int low = 0;
        int hi = alphaBetOnlyInput.Length - 1;

        while (low < hi)
        {
            if (alphaBetOnlyInput[low] != alphaBetOnlyInput[hi])
            {
                return false;
            }
            low++;
            hi--;
        }

        // for (int i = 0; i < alphaBetOnlyInput.Length; i++)
        // {
        //     if (alphaBetOnlyInput[i] != alphaBetOnlyInput[alphaBetOnlyInput.Length - 1 - i])
        //     {
        //         isPalindrome = false;
        //         break;
        //     }
        // }

        return true;
    }
}