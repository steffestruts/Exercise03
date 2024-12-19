using MainApp.Models;
using MainApp.Services;
namespace MainApp.Dialogs;

public class MenuDialog(MenuService menuService)
{
    private readonly MenuService _menuService = menuService;

    public void MenuOptionsDialog()
    {
        while (true)
        {
            Console.WriteLine("1. Visa alla användare");
            Console.WriteLine("2. Skapa en ny kontakt");
            var option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("--- Visar användare --- \n");
                    _menuService.ViewAllUsersDialog();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("--- Skapa en ny användare --- \n");
                    _menuService.CreateUserDialog();
                    break;

                // Clear the console
                case "clr":
                    Console.Clear();
                    break;

                // Quit the application
                case "q":
                    Environment.Exit(-1);
                    return;

                // Invalid input - Try again message
                default:
                    Console.WriteLine("\nOgiltig inmatning! Försök igen.\n");
                    break;
            }
        }
    }
}
