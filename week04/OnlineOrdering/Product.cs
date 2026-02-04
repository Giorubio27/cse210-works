public class Product
{
    private string _pname;

    private string _productid;

    private double _price;

    private double _quantity;

    public double TotalCost()
    {
        return _quantity * _price;
    }
    public string GetPackingLabel()
    {
        return $"{_pname}: {_productid}\n";
    }
    public Product(string pname, string pid, double price, double quantity )
    {
        _pname = pname;
        _productid = pid;
        _price = price;
        _quantity = quantity;
    }
}