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
        return "";
    }
}