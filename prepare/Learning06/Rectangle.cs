
public class Rectangle : Shape
{
    double _side1;
    double _side2;
    public Rectangle (string color, double side1, double side2):base(color)
    {
        this._side1 = side1;
        this._side2 = side2;
    }

    public override double GetArea()
    {
        return this._side1 * this._side2;
    }
}