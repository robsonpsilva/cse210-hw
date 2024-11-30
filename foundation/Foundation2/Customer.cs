
class Customer
{
    private string _customerName;
    private Address _customerAddress;

    public Customer(string customerName, Address customerAddress)
    {
        this._customerName = customerName;
        this._customerAddress = customerAddress;
    }

    public bool liveInUSA()
    {
        return _customerAddress.isInUSA();
    }

    public void SetCustomerName(string customerName)
    {
        this._customerName = customerName;
    }

    public void SetCustomerAddress(Address customerAddress)
    {
        this._customerAddress = customerAddress;
    }

    public string GetCustomerName()
    {
        return this._customerName;
    }

    public Address GetCustomerAddress()
    {
        return this._customerAddress;
    }

}