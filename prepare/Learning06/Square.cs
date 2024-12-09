
public class Square : Shape
{
    float _side;
    public Square(string color, float side):base(color)
    {
        this._side = side;
    }

    public override double GetArea()
    {
        return Math.Pow(this._side,2);
    }
}