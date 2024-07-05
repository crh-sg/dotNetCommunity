// See https://aka.ms/new-console-template for more information
using System.Drawing;

OpenClosePrincipleApplied.IShape circle = new OpenClosePrincipleApplied.Circle { Radius = 5 };
OpenClosePrincipleApplied.IShape rectangle = new OpenClosePrincipleApplied.Rectangle { Width = 4, Height = 6 };
//OpenClosePrincipleApplied.IShape triangle = new OpenClosePrincipleApplied.Triangle { Base = 3, Height = 4 };

OpenClosePrincipleApplied.AreaCalculator calculator = new OpenClosePrincipleApplied.AreaCalculator();

Console.WriteLine("Area of Circle: " + calculator.CalculateArea(circle));
Console.WriteLine("Area of Rectangle: " + calculator.CalculateArea(rectangle));
//Console.WriteLine("Area of Triangle: " + calculator.CalculateArea(triangle));
