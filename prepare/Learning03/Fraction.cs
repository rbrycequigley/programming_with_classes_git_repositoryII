public class Fraction
{   
    // attributes
    private int _top;
    private int _bottom;

    // constructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int numerator)
    {
        _top = numerator;
        _bottom = 1;
    }
    public Fraction(int numerator, int denominator)
    {
        _top = numerator;
        _bottom = denominator;
    }
    // Getters and Setters
    public void GetTop()
    {
        Console.WriteLine($"{_top}");
    }
    public void GetBottom()
    {
        Console.WriteLine($"{_bottom}");
    }
    public void SetTop(int numerator)
    {
        _top = numerator;
    }
    public void SetBottom(int denominator)
    {
        _bottom = denominator;
    }
    // 
    public string getFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    public double getFractionDouble()
    {
        return (double)_top/_bottom;
    }
    public void getFractionBoth()
    {
        Console.WriteLine($"String: {getFractionString()}\nDouble: {getFractionDouble()}");
    }
}