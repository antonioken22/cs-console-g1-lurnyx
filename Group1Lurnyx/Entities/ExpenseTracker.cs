/**
 * @author Dojoles, Jaier Franze
 * @createdAt June 9, 2025
 */

class ExpenseTracker
{
    // Class Variables
    private double _budget;
    private readonly List<Expense> _expenses = new List<Expense>();

    // ===== Main Methods =====

    // 1. set budget w/ loop and validation
    public void SetBudget()
    {
        Console.Write("Enter your budget: ₱");
        _budget = GetPositiveNumber(); // get positive number for budget
    }

    // 2. add items to expenses list
    public void AddExpenses()
    {
        Console.Write("\nHow many items to add? ");
        int count = GetPositiveInteger();

        for (int i = 0; i < count; i++)
        {
            Console.Write($"\nItem #{i + 1} name: ");
            string name = Console.ReadLine();

            Console.Write($"Amount: ₱");
            double amount = GetPositiveNumber();

            _expenses.Add(new Expense(name, amount));
            Console.WriteLine($"✔️ {name} added");
        }
    }

    // 3. show summary of expenses
    public void ShowSummary()
    {
        Console.WriteLine("\n=== EXPENSE SUMMARY ===");

        double total = 0;
        foreach (var expense in _expenses)
        {
            expense.Display();
            total += expense.Amount;
        }

        Console.WriteLine($"\nTOTAL SPENT: ₱{total}");
        Console.WriteLine($"REMAINING: ₱{_budget - total}");

        // check budget status
        if (total > _budget)
            Console.WriteLine("⚠️WARNING!: OVER BUDGET!"); // if total spent is greater than budget
        else if (total == _budget)
            Console.WriteLine("✔️ Budget used exactly"); // if total spent is equal to budget
        else
            Console.WriteLine($"✔️ Under budget by ₱{_budget - total}"); // if total spent is less than budget
    }

    // ===== Helper Methods =====
    //for positive number input in SetBudget and AddExpenses methods
    private double GetPositiveNumber()
    {
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out double num) && num >= 0) // validate positive number
                return num;
            Console.Write("Invalid amount! \nTry again: ₱");
        }
    }

    // for positive integer input in AddExpenses method
    private int GetPositiveInteger()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int num) && num > 0)
                return num;
            Console.Write("Invalid number! \nTry again: ");
        }
    }
}