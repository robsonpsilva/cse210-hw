
class Product
{
    private int _productId;
    private string _productName;
    private double _productPrice;

    private double _productQuantity;

    public Product(int productId, string productName, double productPrice, double productQuantity)
    {
        this._productId = productId;
        this._productName = productName;
        this._productPrice = productPrice;
        this._productQuantity = productQuantity;
    }

    public double GetTotalCost()
    {
       return this._productPrice * this._productQuantity; 
    }

    public int GetProductId()
    {
        return this._productId;
    }

    public string GetProductName()
    {
        return this._productName;
    }

    public double GetProductPrice()
    {
        return this._productPrice;
    }

    public double GetProductQuantity()
    {
        return this._productQuantity;
    }

    public void SetProductId(int productId)
    {
        this._productId = productId;
    }
    
    public void SetProductName(string productName)
    {
        this._productName = productName;
    }

    public void SetProductPrice(double productPrice)
    {
        this._productPrice = productPrice;
    }

    public void SetProductQuantity(double productQuantity)
    {
        this._productQuantity = productQuantity;
    }
}