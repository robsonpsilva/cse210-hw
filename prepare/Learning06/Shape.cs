
public class Shape
{
    private string _color;

    public Shape(string color)
    {
        this._color = color;
    }
    
    public string GetColor()
    {
        return this._color;
    } 

    public void setColor(string color)
    {
        this._color = color;
    }

    public virtual double GetArea()
    {
        return 0;
    }
}