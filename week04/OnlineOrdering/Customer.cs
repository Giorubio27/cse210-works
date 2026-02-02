public class Customer
{
    private string _custName;

    private string _address;

    public bool LiveInUsa()
    {
        return true;
    }
    public Customer(string customerName, Address address)
    {
        _custName = customerName;
        
    }
}