using System;
using Geometric.Entities.Enums;
using Geometric.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Geometric
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> Shapes = new List<Shape>();
            Console.WriteLine("Welcome to the shape raid's calculator!");
            Console.WriteLine("How many shapes you want to calculate?");
            int qtShapes = int.Parse(Console.ReadLine());                    

            for (int i = 1; i < qtShapes + 1; i++) {
                bool validColor = false;
                Color ColorShape = new Color();
                Console.WriteLine("Enter the #{0} shape", i);
                
                Console.WriteLine("Rectangle or Cicle? (r/c)");
                char tpShape = char.Parse(Console.ReadLine().ToUpper().Trim());

                while (validColor == false) do 
                    { 
                    string TempColorShape;
                    Console.WriteLine("Color? (Black/Blue/Red");

                    TempColorShape = Console.ReadLine();
                    validColor = (TempColorShape == "Black" || TempColorShape == "Blue" || TempColorShape == "Red");
                     
                    if (validColor){
                        ColorShape = Enum.Parse<Color>(TempColorShape);
                    }

                 

                if (tpShape == 'R')
                {
                    Console.Write("width: ");                    
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("heigth: ");
                    double heigth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Shapes.Add(new Rectangle(ColorShape, width, heigth));
                }
                else
                {
                    Console.Write("Raid: ");
                    double raid = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Shapes.Add(new Circle(ColorShape, raid));
                }
            
            
            }
            foreach (Shape Shape in Shapes)
            {
                Console.WriteLine(Shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }


        }

        
    }
}
