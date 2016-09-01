interface IDatabase
{
    // all of our clients use this method
    void Add();  
    
    // we added this for a new client, they are the only ones using it
    void Read(); 
}
