/**
 * @author Dojoles, Jaier Franze
 * @createdAt June 9, 2025
 */

class Expense
{
    // Properties (Variables)
    public string ItemName { get; }
    public double Amount { get; }

    // Constructor (Special Method)
    public Expense(string name, double amount)
    {
        ItemName = name;
        Amount = amount;
    }

    // Method to display expense
    public void Display()
    {
        Console.WriteLine($"- {ItemName}: ₱{Amount}");
    }
}