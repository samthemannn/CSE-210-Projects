class Circle
{
    private double _radius;

    public void SetRadius(double radius)
    {
        if (radius < 0)
        {
            textspeed.TypeText("Error, radius must > 0");
        }
        _radius = radius;
    }
    public double GetRadius()
    {
        return _radius;
    }

    public double GetArea ()
    {
        return Math.PI * _radius * _radius;
    }



}


