class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        this._streetAddress = streetAddress;
        this._city = city;
        this._stateProvince = stateProvince;
        this._country = country;
    }

    public bool isInUSA()
    {
        return _country.ToUpper() == "USA";
    }
    public string GetFullAddress()
    {
        string address = _streetAddress + Environment.NewLine + $"{_city}, {_stateProvince}"
        + Environment.NewLine + _country;
        return address;
    }

    public void SetStreetAddress(string streetAddress)
    {
        this._streetAddress = streetAddress;
    }
    public void SetCity(string city)
    {
        this._city = city;
    }

    public void SetStateProvince(string stateProvince)
    {
        this._stateProvince = stateProvince;
    }

    public void SetCountry(string country)
    {
        this._country = country;
    }
}