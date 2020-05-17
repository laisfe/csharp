using shapesInterfaces.Entities.Enums;

namespace shapesInterfaces.Entities
{
    abstract class AbstractShape : IShape
    {

        public Color Color { get; set; }

        public abstract double Area();
    }

}
