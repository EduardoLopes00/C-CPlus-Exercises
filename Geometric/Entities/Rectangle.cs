﻿using System;
using System.Collections.Generic;
using System.Text;
using Geometric.Entities.Enums;

namespace Geometric.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle() { }

        public Rectangle(Color color, double width, double height) : base(color) {
            Width = width;
            Height = height;        
        }
                
        public override double Area()
        {
            return Height * Width;
        }
    }
}
