using Geometric.Entities.Enums;

namespace Geometric.Entities


{
    abstract class Shape
    {
        public Color ColorShape { get; set; }

        public Shape() { }

        public Shape(Color colorShape) {
            ColorShape = colorShape;
        }


        public abstract double Area();

        
    }
}
