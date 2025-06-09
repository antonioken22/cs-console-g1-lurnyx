/**
 * @author Lauron, Romella
 * @createdAt June 9, 2025
 */

using Group1Lurnyx.Entities.BaseEntities;
using Group1Lurnyx.WrapperClasses.ApplicationClasses;

namespace Group1Lurnyx.WrapperClasses
{
    public class ShapeCalculatorWrapper
    {
        ShapeCalculator functionality;

        public ShapeCalculatorWrapper(ShapeCalculator functionality)
        {
            this.functionality = functionality;
        }

        public void Run() => functionality.Run();
        public Shape[] Shapes { get => functionality.Shapes; set => functionality.Shapes = value; }
        
    }
}
