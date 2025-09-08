public class MaxProfit
{
    public static int Caculate(int[] prices)
    {
        int lowPrice = int.MaxValue;
        int profitRecord = 0;

        foreach (var currentPrice in prices)
        {
            if (currentPrice < lowPrice)
            {
                lowPrice = currentPrice;
                continue;
            }
            else if (currentPrice - lowPrice > profitRecord)
            {
                profitRecord = currentPrice - lowPrice;
            }
        }

        return profitRecord;
    }
}