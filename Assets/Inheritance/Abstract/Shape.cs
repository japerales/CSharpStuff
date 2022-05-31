using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape
{
    protected string name;
    public abstract float GetArea();
    public abstract float GetPerimeter();
}

public class Triangle : Shape
{
    private float side;

    public Triangle(float side)
    {
        this.side = side;
    }

    public override float GetArea()
    {
        return side / 2;
    }

    public override float GetPerimeter()
    {
        return side*3;
    }
}

public class Square : Shape
{
    private float side;

    public Square(float side)
    {
        this.side = side;
    }

    public override float GetArea()
    {
        return side*side;
    }

    public override float GetPerimeter()
    {
        return side*4;
    }
}

public class Rectangle : Shape
{
    private float b, a;

    public Rectangle(float a, float b)
    {
        this.a = a;
        this.b = b;
    }

    public override float GetArea()
    {
        return b * a;
    }

    public override float GetPerimeter()
    {
        return b*2+a*2;
    }
}
