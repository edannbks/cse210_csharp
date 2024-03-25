public abstract class Shape
{
    private string _color;
    
    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();
}
// Ask tutor to help me understand why I need the SetColor() setter and what it is
// doing differently than the constructor on line 5.