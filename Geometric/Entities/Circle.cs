using System;
using System.Collections.Generic;
using System.Text;
using Geometric.Entities.Enums;

namespace Geometric.Entities
{
    class Circle : Shape
    {
        const double PI = 3.14;

        public double Radius { get; set; }

        public override double Area()
        {
            return PI * Math.Pow(Radius, 2);
        }

        public Circle() { }

        public Circle(Color color, double radius) : base(color)
        { 
            Radius = radius;
        }

    }
}
