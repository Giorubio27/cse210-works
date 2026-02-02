public class Address
{
    private string _street;

    private string _city;

    private string _state;

    private string _country;


    public bool LiveInUsa()
    {
        if (_country.ToLower() == "usa")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string GetShipping()
    {
        return $"{_street}{_city},{_state}, {_country}";
    }
}