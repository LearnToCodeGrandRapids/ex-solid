public class Customer
{
    public void Create()
    {
        try
        {
            // DbHelper.Insert(this);
        }
        catch (Exception ex)
        {
            System.IO.File.WriteAllText(@"c:\Error.txt", ex.ToString());
        }
    }
    
    public void Update()
    {
        try
        {
            // DbHelper.Update(this);
        }
        catch (Exception ex)
        {
            System.IO.File.WriteAllText(@"c:\Error.txt", ex.ToString());
        }
    }
}
