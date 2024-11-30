
class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer, Product product)
    {
        this._customer = customer;
        this._products.Add(product);
    }
    public Order(Customer customer)
    {
        this._customer = customer;
    }

    public void setProduct(Product product)
    {
        this._products.Add(product);
    }

    public string getPackingLabel()
    {
        string packingLabel = "";
        int count = 0;
        foreach(Product p in this._products)
        {
            count++;
            if (count != this._products.Count())
            {
                packingLabel += $"Product Id: {p.getProductId()} - Product name: {p.getProductName()}" + Environment.NewLine;
            }
            else{
                packingLabel += $"Product Id: {p.getProductId()} - Product name: {p.getProductName()}";
            }
            
        }
        return packingLabel;
    }

    public string getShippingLabel()
    {
        string shippingLabel =_customer.getCustomerName() + Environment.NewLine +
        _customer.getCustomerAddress().getFullAddress();
        return shippingLabel;
    }

    public double getTotalOrderCoast()
    {
        double total = 0;

        //Please note that at this point we are calculating the total without considering whether the customer is in the USA or not.
        foreach (Product p in this._products)
        {
            total += p.getTotalCost();
        }
        if(this._customer.liveInUSA())
        {
            //Adding the shipping price of $5 for shipments within the USA.
            total += 5;
        }
        else
        {
           //Adding the shipping price of $35 for shipments outside the USA. 
           total += 35; 
        }

        return total;
    }
}