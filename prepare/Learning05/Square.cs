using System;

public class Square : Shape
{
    private double _length = 0;

    public Square(double length)
    {
        _length = length;
    }

    public override double GetArea()
    {
        return _length * 2;
    }
}