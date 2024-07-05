# EPAM DotNet Community

## Open / Close Principle

The Open/Closed principle states that software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification. 
This means we should be able to add new functionality without changing existing code, minimizing the risk of introducing bugs into an already working system.

## Code 

In code related in this project, we have two parts. One is a code where the principle is not applied. The second one is the same functionality but with the principle applied.

So the functionality is simple: We need to calculate the area of different geometric shapes. 
In the code where we dont use the principle, we have a method to calculate the area for each shape:
```
public double CalculateArea(object shape)
    {
        if (shape is Circle)
        {
            Circle circle = (Circle)shape;
            return Math.PI * circle.Radius * circle.Radius;
        }
        else if (shape is Rectangle)
        {
            Rectangle rectangle = (Rectangle)shape;
            return rectangle.Width * rectangle.Height;
        }
        else
        {
            throw new ArgumentException("Shape not supported");
        }
    }
```
As you can see, if we want to add anew shape, for example a triangle, we would need to modify the calculate method. And if we want to add more shapes we would have to add mocre code to the same method. 
This is not a good practice.

So in the code with the principle applied, we changed the things. Now we have an interface with this contract:

```
public interface IShape
{
    double CalculateArea();
}
```

And each shape has its own method to calculate the area. In case for example of the rectangle , the code that we have is :

```
public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double CalculateArea()
    {
        return Width * Height;
    }
}
```

As you can see, now our code is easily extendable and if we want to add a new shape, we just need to implement the interface and add the method to calculate the area. For example the triangle would be:

```
public class Triangle : IShape
{
    public double Base { get; set; }
    public double Height { get; set; }

    public double CalculateArea()
    {
        return 0.5 * Base * Height;
    }
}
```

And all new shapes added would not need to modify any of the other previous shapes.

## Conclusions

The idea of the open / close principle is building a code easily extendable and trying to avoid the modifications of the existing classes.

