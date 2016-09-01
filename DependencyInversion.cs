public class Customer
{
    // This file logger is great, but not we need to 
    // support an email logger. We do not know 
    // if the client is going to want a file 
    // logger or email logger until the customer
    // is instantiated.
    private FileLogger obj = new FileLogger();
    
    public virtual void Create()
    {
        try
        {
            // DbHelper.Insert(this);
        }
        catch (Exception ex)
        {
            obj.Handle(ex.ToString());
        }
    }
}
