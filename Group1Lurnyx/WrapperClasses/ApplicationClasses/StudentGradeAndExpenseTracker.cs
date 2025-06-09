/**
 * @author Laurente, John Rhuel & Dojoles, Jaier Franze
 * @createdAt June 9, 2025
 */

namespace Group1Lurnyx.WrapperClasses.ApplicationClasses
{
    public class StudentGradeAndExpenseTracker
    {
        public void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // -------------------- Student GPA Section --------------------
            Console.WriteLine("_______________________________________________");
            Console.WriteLine("Below Student's GPA");

            Console.Write("\nEnter Firstname: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Lastname: ");
            string lastName = Console.ReadLine();

            var student = new Student(firstName, lastName, 0.0);
            student.GetStudentsGrade();

            Console.WriteLine($"\nThe student's GPA is {student.GetGradePointAverage()}");
            student.PassOrFail();

            // -------------------- Expense Tracker Section --------------------
            Console.WriteLine("_______________________________________________");
            Console.WriteLine("💰 EXPENSE TRACKER APP 💰");

            var tracker = new ExpenseTracker();

            // Step 1: Set Budget
            tracker.SetBudget();

            // Step 2: Add Expenses
            tracker.AddExpenses();

            // Step 3: Show Summary
            tracker.ShowSummary();

            Console.WriteLine("\nEnter to exit...");
            Console.ReadLine();
        }

        public StudentGradeAndExpenseTracker()
        {

        }
    }
}
