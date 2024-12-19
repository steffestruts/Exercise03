using MainApp.Models;

namespace MainApp.Services;

public class UserService
{
    private List<User> _users = [];
    private readonly FileService _fileService = new(@"c:\projekt", "exercise03-users.json");

    public void Add(User user)
    {
        _users.Add(user);
        _fileService.SaveListToFile(_users);
    }

    public IEnumerable<User> GetAll()
    {
        _users = _fileService.LoadListFromFile();
        return _users;
    }
}
