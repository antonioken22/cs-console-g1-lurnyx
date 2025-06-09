/**
 * @author Lauron, Romella
 * @createdAt June 9, 2025
 */

using Group1Lurnyx.Entities.BaseEntities;

namespace Group1Lurnyx.Entities
{
    public class Circle : Shape
    {
        public Circle(double radius) 
            : base(radius)
        {
        }
        public Circle()
        {

        }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double GetSurfaceArea()
        {
            throw new NotImplementedException();
        }

        public override double GetVolume()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Shape: Circle, Radius: {Radius.ToString("N2")}, Area: {GetArea().ToString("N2")}";
        }
    }
}
