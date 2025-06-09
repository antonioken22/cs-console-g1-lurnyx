/**
 * @author Laurente, John Rhuel & Dojoles, Jaier Franze
 * @createdAt June 9, 2025
 */

using Group1Lurnyx.WrapperClasses.ApplicationClasses;

namespace Group1Lurnyx.WrapperClasses
{
    public class StudentGradeAndExpenseTrackerWrapper
    {
        private StudentGradeAndExpenseTracker Alren;

        public StudentGradeAndExpenseTrackerWrapper(StudentGradeAndExpenseTracker alren)
        {
            Alren = alren;
        }
        public void Access()
        {
            Console.Clear();
            Alren.Run();
            Console.ReadKey();
        }

    }
   
}
