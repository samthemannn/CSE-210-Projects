class Cylinder
{
    private Circle _circle;

    private double _height;

    public Cylinder()
    {
        _height = 0;
        _circle = null;
    }

    public Cylinder(Circle circle)
    {
    }
    public void SetCircle(Circle circle)
    {
        _circle = circle;
        SetHeight(10);
    }

    public void SetHeight(double height)
    {
        if(height < 0)
        {
            Console.WriteLine("Error, cannont set a negative value.");
            return;
        }
        _height = height;
    }

    public double GetVolume()
    {
        // double radius = _circle.GetRadius();
        return _circle.GetArea() * _height;
        // return Math.PI * radius * radius * _height;

    }
}