
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

    public void SetProduct(Product product)
    {
        this._products.Add(product);
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        int count = 0;
        foreach(Product p in this._products)
        {
            count++;
            if (count != this._products.Count())
            {
                packingLabel += $"Product Id: {p.GetProductId()} - Product name: {p.GetProductName()}" + Environment.NewLine;
            }
            else{
                packingLabel += $"Product Id: {p.GetProductId()} - Product name: {p.GetProductName()}";
            }
            
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel =_customer.GetCustomerName() + Environment.NewLine +
        _customer.GetCustomerAddress().GetFullAddress();
        return shippingLabel;
    }

    public double GetTotalOrderCoast()
    {
        double total = 0;

        //Please note that at this point we are calculating the total without considering whether the customer is in the USA or not.
        foreach (Product p in this._products)
        {
            total += p.GetTotalCost();
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