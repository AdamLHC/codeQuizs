using System.Text;

namespace Strings;

public class AddBinary
{
    private bool overflow = false;
    private int currentBit = 0;

    private void AddBitToCurrent()
    {
        if (currentBit == 0)
        {
            currentBit = 1;
        }
        else
        {
            overflow = true;
            currentBit = 0;
        }
    }
    public string Add(string a, string b)
    {
        char[] aBits = a.ToCharArray();
        char[] bBits = b.ToCharArray();
        int aIndex = a.Length - 1;
        int bIndex = b.Length - 1;
        var ans = "";

        while (aIndex >= 0 || bIndex >= 0 || overflow != false)
        {
            if (overflow == true)
            {
                overflow = false;
                AddBitToCurrent();
            }

            if (aIndex >= 0 && aBits[aIndex] == '1')
            {
                AddBitToCurrent();
            }
            aIndex--;

            if (bIndex >= 0 && bBits[bIndex] == '1')
            {
                AddBitToCurrent();
            }
            bIndex--;

            ans = currentBit.ToString() + ans;
            currentBit = 0;
        }
        return ans;
    }

    public string BetterAdd(string a, string b)
    {
        int aIndex = a.Length - 1;
        int bIndex = b.Length - 1;
        int carry = 0;
        string result = "";

        while (aIndex >= 0 || bIndex >= 0 || carry > 0)
        {
            int sum = carry;
            if (aIndex >= 0) sum += a[aIndex] - '0';
            if (bIndex >= 0) sum += b[bIndex] - '0';

            result = (sum % 2) + result;
            carry = sum / 2;
            aIndex--;
            bIndex--;
        }
        return result;
    }
}