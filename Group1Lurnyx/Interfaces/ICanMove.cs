/**
 * @author Antonio, Kenette John
 * @createdAt June 9, 2025
 */
 
namespace Group1Lurnyx.Interfaces
{
    public interface ICanMove
    {
        public double Velocity { get; set; }

        public void Run(int id, string name);
        public void Back();
        public double GetVelocity(double distance, double time);
    }
}
