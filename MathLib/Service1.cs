using System;


namespace MathLib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public double AreaOfCube(double a)
        {
            double result = 6 * Math.Pow(a, 2);
            Console.WriteLine($"Recieved Cube Area a={a}");
            Console.WriteLine($"Result: {result}");
            return result;
        }
        public double AreaOfRectangularPrism(double l, double w, double h)
        {
            double result = 2 * ((w * l) + (h * l) + (w + h));
            Console.WriteLine($"Recieved Rectangular Prism Area l={l} w={w} h={h}");
            Console.WriteLine($"Result: {result}");
            return result;
        }
        public double AreaOfCylinder(double r, double h)
        {
            double result = 2 * Math.PI * r * (r + h);
            Console.WriteLine($"Recieved Cylinder Area r={r} h={h}");
            Console.WriteLine($"Result: {result}");
            return result;
        }
        public double AreaOfCone(double r, double l)
        {
            double result = Math.PI * r * (r + l);
            Console.WriteLine($"Recieved Cone Area r={r} l={l}");
            Console.WriteLine($"Result: {result}");
            return result;
        }

    }
}
