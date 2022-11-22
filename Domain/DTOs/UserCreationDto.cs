namespace Domain.DTOs;

public class UserCreationDto
{
    public string UserName { get;}
    public string Password { get; }
    public string Name { get; }

    public UserCreationDto(string userName, string password, string name)
    {
        UserName = userName;
        Password = password;
        Name = name;
    }
}