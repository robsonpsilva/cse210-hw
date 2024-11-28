
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

    public double getTotalCost()
    {
       return this._productPrice * this._productQuantity; 
    }

    public int getProductId()
    {
        return this._productId;
    }

    public string getProductName()
    {
        return this._productName;
    }

    public double getProductPrice()
    {
        return this._productPrice;
    }

    public double getProductQuantity()
    {
        return this._productQuantity;
    }

    public void setProductId(int productId)
    {
        this._productId = productId;
    }
    
    public void setProductName(string productName)
    {
        this._productName = productName;
    }

    public void setProductPrice(double productPrice)
    {
        this._productPrice = productPrice;
    }

    public void setProductQuantity(double productQuantity)
    {
        this._productQuantity = productQuantity;
    }
}