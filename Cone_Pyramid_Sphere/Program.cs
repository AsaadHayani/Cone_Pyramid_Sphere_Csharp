using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
  class Program
  {
    static void Vol(double radius, double height)
    {
      double division = 1.0 / 3.0;
      double pi = Math.PI;
      double pow = Math.Pow(radius, 2);
      double result = division * pi * pow * height;
      Console.WriteLine("Valume Cone = " + result);
    }
    static void Vol(int base_area, double height)
    {
      double division = 1.0 / 3.0;
      double result = division * base_area * height;
      Console.WriteLine("Valume Pyramid = " + result);
    }
    static void Vol(double radius)
    {
      double division = 4.0 / 3.0;
      double pi = Math.PI;
      double pow = Math.Pow(radius, 3);
      double result = division * pi * pow;
      Console.WriteLine("Valume Sphere = " + result);
    }
    static void Main(string[] args)
    {
      Again:

      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("Calculates the Valume of a Cone");
      Console.WriteLine("Enter Values Radius and Height");
      Vol(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));

      Console.WriteLine("\n");

      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("Calculates the Valume of a Pyramid");
      Console.WriteLine("Enter Values Base Area and Height");
      Vol(Convert.ToInt32(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));

      Console.WriteLine("\n");

      Console.ForegroundColor = ConsoleColor.DarkYellow;
      Console.WriteLine("Calculates the Valume of a Sphere");
      Console.WriteLine("Enter Values Radius");
      Vol(Convert.ToInt32(Console.ReadLine()));

      Console.WriteLine();
      goto Again;
    }
  }
}