
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

    public void setCustomerName(string customerName)
    {
        this._customerName = customerName;
    }

    public void setCustomerAddress(Address customerAddress)
    {
        this._customerAddress = customerAddress;
    }

    public string getCustomerName()
    {
        return this._customerName;
    }

    public Address getCustomerAddress()
    {
        return this._customerAddress;
    }

}