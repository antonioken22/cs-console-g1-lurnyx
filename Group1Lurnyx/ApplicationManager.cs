/**
 * @author Antonio, Kenette John
 * @createdAt June 9, 2025
 */

using Group1Lurnyx.Entities.Enums;
using Group1Lurnyx.Services;
using Group1Lurnyx.WrapperClasses;
using Group1Lurnyx.WrapperClasses.ApplicationClasses;

namespace Group1Lurnyx
{
    internal class ApplicationManager
    {
        StudentGradeAndExpenseTrackerWrapper studentGradeAndExpenseTrackerWrapper;
        ShapeCalculatorWrapper shapeCalculatorWrapper;
        CatAndMouseSimulatorWrapper catAndMouseSimulatorWrapper;
        
        Stack<ApplicationPageEnum> navigationHistory;

        public ApplicationManager()
        {
            StudentGradeAndExpenseTracker studentGradeAndExpenseTracker = new StudentGradeAndExpenseTracker();
            ShapeCalculator shapeCalculator = new ShapeCalculator();
            CatAndMouseSimulator catAndMouseSimulator = new CatAndMouseSimulator();

            studentGradeAndExpenseTrackerWrapper = new StudentGradeAndExpenseTrackerWrapper(studentGradeAndExpenseTracker);
            shapeCalculatorWrapper = new ShapeCalculatorWrapper(shapeCalculator);
            catAndMouseSimulatorWrapper = new CatAndMouseSimulatorWrapper(catAndMouseSimulator);
            
            navigationHistory = new Stack<ApplicationPageEnum>();
        }
        public void Start()
        {
            Console.Title = "Group 1";
            GotoPage(ApplicationPageEnum.LaunchApp);
        }
        private void DisplaySelection(string title, ApplicationPageEnumWrapper[] options)
        {
            var mainMenu = new MenuScroller(title, options);
            ApplicationPageEnum selectedPage = mainMenu.Run();
            GotoPage(selectedPage);
        }
        private void GotoPage(ApplicationPageEnum page, bool isPrev = false)
        {
            if (page != ApplicationPageEnum.Back && !isPrev) navigationHistory.Push(page);

            switch (page)
            {
                case ApplicationPageEnum.LaunchApp:
                    ShowMainMenu();
                    break;
                case ApplicationPageEnum.Start:
                    ShowSimulatorMenu();
                    break;
                case ApplicationPageEnum.About:
                    RunDisplayAboutInfo();
                    break;
                case ApplicationPageEnum.Exit:
                    RunExit();
                    break;
                case ApplicationPageEnum.W4A2:
                    // Student Grade and Expense Tracker - Laurente, John Rhuel & Dojoles, Jaier Franze (Respectively)
                    studentGradeAndExpenseTrackerWrapper.Access();
                    break;
                case ApplicationPageEnum.W6A1:
                    // Shape Calculator - Lauron Romella
                    RunWeek6Assignment1App();
                    break;
                case ApplicationPageEnum.W6A2:
                    // Cat And Mouse Simulator - Antonio, Kenette John 
                    RunCatAndMouseSimulatorApp();
                    break;
                case ApplicationPageEnum.Back:
                    navigationHistory.Pop();
                    GotoPage(navigationHistory.Peek(), true);
                    return;
            }
            GotoPage(ApplicationPageEnum.Back, true);
        }
        private void ShowMainMenu()
        {
            DisplaySelection("WELCOME TO THE GROUP 1 SIMULATOR APP", new ApplicationPageEnumWrapper[]
            {
                new ApplicationPageEnumWrapper(ApplicationPageEnum.Start),
                new ApplicationPageEnumWrapper(ApplicationPageEnum.About),
                new ApplicationPageEnumWrapper(ApplicationPageEnum.Exit),
            });
        }
        private void ShowSimulatorMenu()
        {
            DisplaySelection("THE GROUP 1 MENU", new ApplicationPageEnumWrapper[]
            {

                new ApplicationPageEnumWrapper(ApplicationPageEnum.W4A2),
                new ApplicationPageEnumWrapper(ApplicationPageEnum.W6A1),
                new ApplicationPageEnumWrapper(ApplicationPageEnum.W6A2),
                new ApplicationPageEnumWrapper(ApplicationPageEnum.Back)
            });
        }
        private void RunExit()
        {
            Console.Clear();


            ZConsole.Write("Thank you for using the Group 1 Simulator App!", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.MIDDLE_CENTER);
            Console.SetCursorPosition(0, 18);
            Environment.Exit(0);
        }
        private void RunDisplayAboutInfo()
        {
            Console.Clear();
            ZConsole.Init(Console.WindowWidth, Console.WindowHeight);

            ZConsole.DrawBox(0, Console.WindowWidth - 1, 0, 2);
            ZConsole.Write("ABOUT", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.TOP_CENTER, yOffset: 1);

            ZConsole.DrawBox(0, Console.WindowWidth - 1, 3, Console.WindowHeight - 5);
            ZConsole.Write("This program was created by:", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.TOP_LEFT, yOffset: 4, xOffset: 2);
            ZConsole.Write("Laurente, John Rhuel - Leader", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.TOP_LEFT, yOffset: 6, xOffset: 2);
            ZConsole.Write("Dojoles, Jaier Franze R.", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.TOP_LEFT, yOffset: 7, xOffset: 2);
            ZConsole.Write("Antonio, Kenette John A.", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.TOP_LEFT, yOffset: 8, xOffset: 2);
            ZConsole.Write("Lauron, Romella", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.TOP_LEFT, yOffset: 9, xOffset: 2);

            ZConsole.DrawBox(0, Console.WindowWidth - 1, Console.WindowHeight - 4, Console.WindowHeight - 2);
            ZConsole.Write("Thank you for using the app. Press any key to return to the menu.", 0, 0, null, null, flag: ZConsole.ConsoleFormatFlags.BOTTOM_LEFT, yOffset: 3, xOffset: 2);

            Console.ReadKey(true);
            GotoPage(ApplicationPageEnum.Back, true);
        }
        private void RunWeek6Assignment1App()
        {
            Console.Clear();
            Console.CursorVisible = true;
            shapeCalculatorWrapper.Run();
        }
        
        private void RunCatAndMouseSimulatorApp()
        {
            Console.Clear();
            catAndMouseSimulatorWrapper.Run();
        }
    }
}
