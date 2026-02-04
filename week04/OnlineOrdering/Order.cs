using System.Runtime.CompilerServices;

public class Order
{
    private List<Product> _products = new List<Product>();

    private Customer _customer;

    public double GetTotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.TotalCost();


        }
        if (_customer.LiveInUsa() == true)
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;

    }
    public string GetShipping()
    {
        return $"***Shipping Label***\n {_customer.GetName()}\n{_customer.GetFullAddy()}";
    }
    public string GetPackingLabel()
    {
        string label = "***packing label***\n";

        foreach (Product product in _products)
        {
            label += product.GetPackingLabel();
        }
        return label;
    }
    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }
    
}