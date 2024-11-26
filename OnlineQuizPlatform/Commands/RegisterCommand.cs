using OnlineQuizPlatform.Exceptions;
using OnlineQuizPlatform.Repositorys;

namespace OnlineQuizPlatform.Commands;

public class RegisterCommand
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }


    public void Validate()
    {
        if (Name.Length < 1 || Name.Length > 100)
            throw new ValidationException("Text's symbol amount  should be between 1 to 100");

        if (string.IsNullOrWhiteSpace(Email))
            throw new ValidationException("Email must be valid, also ut must not be empty");

        if (Email.Length > 100)
            throw new ValidationException("Email should contain maximum 100 symbols");

        if (new UserRepository().GetAllUsers().Any(user => user.Email == Email))
            throw new ValidationException("Email already exists.");

        if (Password.Length < 8 || Password.Length > 16)
            throw new ValidationException("Password must be between 6 to 16 symbols");
    }
}