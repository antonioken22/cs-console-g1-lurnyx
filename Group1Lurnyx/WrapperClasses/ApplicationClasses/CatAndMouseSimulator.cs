/**
 * @author Antonio, Kenette John
 * @createdAt June 9, 2025
 */

using Group1Lurnyx.Entities.Enums;
using Group1Lurnyx.Services;
using Group1Lurnyx.Entities;

namespace Group1Lurnyx.WrapperClasses.ApplicationClasses
{
    public class CatAndMouseSimulator
    {

        Stack<ApplicationPageEnum> navigationHistory;

        public CatAndMouseSimulator()
        {
            navigationHistory = new Stack<ApplicationPageEnum>();
        }

        public void Run()
        {
            GotoPage(ApplicationPageEnum.W6A2);
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
                case ApplicationPageEnum.W6A2:
                    ShowCatAndJerryMenu();
                    break;
                case ApplicationPageEnum.Cat:
                    var c = new Cat();
                    c.StartCat();
                    break;
                case ApplicationPageEnum.Jerry:
                    var j = new Mouse();
                    j.StartJerry();
                    break;
                case ApplicationPageEnum.Back:
                    GotoPage(ApplicationPageEnum.Start);
                    break;
            }
        }

        private void ShowCatAndJerryMenu()
        {
            DisplaySelection("Cat and Mouse Simulator [THE CAT AND JERRY]", new ApplicationPageEnumWrapper[]
            {
                new ApplicationPageEnumWrapper(ApplicationPageEnum.Cat),
                new ApplicationPageEnumWrapper(ApplicationPageEnum.Jerry),
                new ApplicationPageEnumWrapper(ApplicationPageEnum.Back)
            });
        }
    }
}
