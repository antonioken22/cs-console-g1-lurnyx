
/**
 * @author Laurente, John Rhuel
 * @createdAt June 9, 2025
 */


using Group1Lurnyx.Entities;

public class Student : Human
{
    private double gradePointAverage;
    private double[] grades;

    public Student()
    {
        this.grades = new double[5];
        this.gradePointAverage = 0.0;
    }

    public Student(string firstName, string lastName, double gradeGPA)
       : base(firstName, lastName)
    {
        this.grades = new double[5];
        this.gradePointAverage = gradeGPA;
    }

    public void Showdetails()
    {
        Console.WriteLine("\n\tThe student's GPA is {0}", this.gradePointAverage);
    }
    public void GetStudentsGrade()
    {
        Console.Write("\tEnter Grades for GPA Calculation (5.0 - 1.0)\n");
        for (int i = 0; i < grades.Length; i++)
        {
            Console.Write("\tEnter Grade {0}: ", i + 1);

            double temp = double.Parse(Console.ReadLine());
            while (temp < 1.0 || temp > 5.0)
            {
                Console.Write("\tInvalid input! Please enter a grade between 1.0 and 5.0: ");
                temp = double.Parse(Console.ReadLine());
            }
            grades[i] = temp;
        }
        this.gradePointAverage = CalculateGPA();

    }
    public void PassOrFail()
    {
        if (this.gradePointAverage > 3.0)
        {
            Console.WriteLine("\t{0} {1} - Failed\n", FirstName, LastName);

        }
        else Console.WriteLine("\t{0} {1} - Passed\n", FirstName, LastName);
    }

    private double CalculateGPA()
    {
        double sum = 0.0;
        for (int i = 0; i < grades.Length; i++)
        {
            sum += grades[i];
        }
        return sum / grades.Length;
    }


    public double[] GetGrades()
    {
        return this.grades;
    }
    public void SetGrades(double[] grades)
    {
        this.grades = grades;
        this.gradePointAverage = CalculateGPA();
    }
    public double GetGradePointAverage()
    {
        return this.gradePointAverage;
    }
    public void SetGradePointAverage(double gradePointAverage)
    {
        this.gradePointAverage = gradePointAverage;
    }

}
