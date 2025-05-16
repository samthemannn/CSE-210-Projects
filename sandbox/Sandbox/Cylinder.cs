class Cylinder
{
    private Circle _circle;
    private double _height;

    public void SetCircle(Circle circle)
    {
        _circle = circle;
    }
    public void SetHeight(double height)
    {
        _height = height;

    }

    public double GetVolume()
    {
        double radius = _circle.GetRadius();
        return _circle.GetArea() * _height;
    }

  
}
