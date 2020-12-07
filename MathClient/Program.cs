using System;
using MathClient.ServiceReference1;

namespace MathClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client();
            Console.WriteLine("Welcome to the 3D Area Calculator");
            double value1 = 0, value2 = 0, value3 = 0, result;
            double choice = getInput("Enter an operation 0-4, 1=Cube, 2=Rectangular Prism, 3=Cylinder, 4=Cone, 0=quit: ", 4);
            while (choice != 0)
            {
                if (choice == 1)
                {
                    value1 = getInput("Enter Edge Length: ", 32766);
                    result = client.AreaOfCube(value1);
                    Console.WriteLine($"Area of Cube with Edge Length of {value1} = {result}");
                }
                else if (choice == 2)
                {
                    value1 = getInput("Enter Length: ", 32766);
                    value2 = getInput("Enter Width: ", 32766);
                    value3 = getInput("Enter Height: ", 32766);
                    result = client.AreaOfRectangularPrism(value1, value2, value3);
                    Console.WriteLine($"Area of Rectangular Prism with length {value1}, width {value2}, and height {value3} = {result}");
                }
                else if (choice == 3)
                {
                    value1 = getInput("Enter Radius: ", 32766);
                    value2 = getInput("Enter Height: ", 32766);
                    result = client.AreaOfCylinder(value1, value2);
                    Console.WriteLine($"Area of Cylinder with radius {value1} and height {value2} = {result}");
                }
                else if (choice == 4)
                {
                    value1 = getInput("Enter Radius: ", 32766);
                    value2 = getInput("Enter Slant Height: ", 32766);
                    result = client.AreaOfCone(value1, value2);
                    Console.WriteLine($"Area of Cone with radius {value1} and slant height {value2} = {result}");
                }
                else
                {
                    Console.WriteLine("Unknown Operation");
                }
                choice = getInput("Enter an operation 0-4, 1=Cube, 2=Rectangular Prism, 3=Cylinder, 4=Cone, 0=quit: ", 4);
            }
            Console.WriteLine("Thanks for using the 3D area calculator.");
            Console.WriteLine("\nPress <Enter> to terminate the client");
            Console.ReadLine();
            client.Close();
        }
        public static double getInput(string prompt, int maxVal)
        {
            //Gets user input for operation and validates
            double c = -1;
            while (c < 0 || c > maxVal)
            {
                try
                {
                    Console.Write(prompt);
                    c = Convert.ToDouble(Console.ReadLine()); //theoretical max is 1.7976931348623157E+308 but I'm going to make it 16 bit int max for my sanity 32766
                    if (c < 0 || c > maxVal)
                    {
                        Console.WriteLine($"0-{maxVal} only");
                        Console.WriteLine();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine($"Illegal Input: 0-{maxVal} only.");
                    c = -1;
                }
            }
            return c;
        }
    }
}
