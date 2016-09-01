public class Customer
{
    // 1 - premium
    // 2 - standard
    private int CustType { get; set; }

    public double GetDiscount(double totalSales)
    {
        if (CustType == 1)
        {
            return totalSales - 100;
        }
        else
        {
            return totalSales - 50;
        }
    }
}
