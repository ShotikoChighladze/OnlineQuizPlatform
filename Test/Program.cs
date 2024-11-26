using OnlineQuizPlatform.Commands;
using OnlineQuizPlatform.Service;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userService = new UserService();
            userService.RegisterUser(new RegisterCommand{ Email = "chigladzeshotiko@gmaill.com", Name = "Shoiko", Password = "shoitko123"});
            userService.RegisterUser(new RegisterCommand { Email = "chigladzejeizi@gmaill.com", Name = "zarala", Password = "zarala123" });

        }
    }
}