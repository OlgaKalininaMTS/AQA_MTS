﻿// See https://aka.ms/new-console-template for more information

namespace Delegate;

public class FormulaClass
{

    public double Circumference(double radius)
    {
        return 2 * Math.PI * radius;
    }
   
    public double AreaCircle(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }
    public double VolumeBall(double radius)
    {
        return (4 / 3) * Math.PI * Math.Pow(radius, 3);
    }
}

