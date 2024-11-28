
class Product
{
    private int _productId;
    private string _productName;
    private float _productPrice;

    private float _productQuantity;

    public Product(int productId, string productName, float productPrice, float productQuantity)
    {
        this._productId = productId;
        this._productName = productName;
        this._productPrice = productPrice;
        this._productQuantity = productQuantity;
    }

    public float getTotalCost()
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

    public float getProductPrice()
    {
        return this._productPrice;
    }

    public float getProductQuantity()
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

    public void setProductPrice(float productPrice)
    {
        this._productPrice = productPrice;
    }

    public void setProductQuantity(float productQuantity)
    {
        this._productQuantity = productQuantity;
    }
}