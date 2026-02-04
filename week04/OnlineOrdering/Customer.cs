public class Customer
{
    private string _custName;

    private Address _address;

    public bool LiveInUsa()
    {
        return _address.LiveInUsa();
    }
    public Customer(string customerName, Address address)
    {
        _custName = customerName;
        _address = address;

    }
    public string GetName()
    {
        return _custName;
    }
    public string GetFullAddy()
    {
        return _address.GetShipping();
    }
}