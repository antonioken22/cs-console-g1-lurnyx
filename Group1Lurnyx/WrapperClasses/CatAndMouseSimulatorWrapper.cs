/**
 * @author Antonio, Kenette John
 * @createdAt June 9, 2025
 */
 
using Group1Lurnyx.WrapperClasses.ApplicationClasses;

namespace Group1Lurnyx.WrapperClasses
{
    public class CatAndMouseSimulatorWrapper
    {
        CatAndMouseSimulator catAndJerry;

        public CatAndMouseSimulatorWrapper(CatAndMouseSimulator catAndJerry)
        {
            this.catAndJerry = catAndJerry;
        }

        public void Run()
        {
            catAndJerry.Run();
        }
    }
}
