using Menu;
namespace MainProgram
{
    public class MainProgram
        /*Our body of the main program 
        contains only the callout for 
        the MainMenu object*/
    {
        public static void Main()
        {
            MainMenu MainMenu = new MainMenu();
            MainMenu.MakeDecision();
        }
    }
}