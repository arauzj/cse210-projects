public class Circle : Shape
{
    private double _radius = 0;
    public Circle(string color, double side) : base(color)
    {
        _radius = side;
    }
    public override double GetArea()
    {
        return Math.PI * (_radius * _radius);
    }
}