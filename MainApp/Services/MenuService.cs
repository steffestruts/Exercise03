using MainApp.Models;

namespace MainApp.Services;

public class MenuService
{
    private readonly UserService _userService = new();

    public void CreateUserDialog()
    {
        User user = new();

        // Input: FirstName
        Console.Write("Skriv in förnamn: ");
        user.FirstName = Console.ReadLine()!;
        // Input: LastName
        Console.Write("Skriv in efternamn: ");
        user.LastName = Console.ReadLine()!;
        // Input: Email
        Console.Write("Skriv in e-postaddress: ");
        user.Email = Console.ReadLine()!;
        Console.WriteLine("");

        // Adding inputs to list as single user
        _userService.Add(user);
    }

    public void ViewAllUsersDialog()
    {
        // Fetching all users
        var users = _userService.GetAll();

        // Loop with foreach and display users one by one
        foreach (var user in users)
        {
            Console.WriteLine($"{"Namn:",-15}{user.FirstName} {user.LastName}");
            Console.WriteLine($"{"E-post:",-15}{user.Email}");
            Console.WriteLine($"{"Id:",-15}{user.Id}");
            Console.WriteLine("");
        }
        Console.WriteLine("---------------------------------------------- \n");

    }
}
