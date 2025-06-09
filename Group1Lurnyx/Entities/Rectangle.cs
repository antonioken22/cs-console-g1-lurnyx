/**
 * @author Lauron, Romella
 * @createdAt June 9, 2025
 */

using Group1Lurnyx.Entities.BaseEntities;

namespace Group1Lurnyx.Entities
{
    public class Rectangle : Shape
    {
        public Rectangle(double length, double width) :
            base(length, width)
        {

        }
        public Rectangle()
        {

        }
        public override double GetArea() => Length * Width;
        public override double GetSurfaceArea() => (2 * Length) + (2 * Width);

        public override double GetVolume()
        {
            throw new InvalidOperationException("2D Shape 'Rectangle' does not have Volume!");
        }

        public override string ToString()
        {
            return $"Shape: Rectangle, Length: {Length.ToString("N2")}, Width: {Width.ToString("N2")} " +
                $", Area: {GetArea().ToString("N2")}, Perimeter: {GetSurfaceArea().ToString("N2")}";
        }
    }
}
