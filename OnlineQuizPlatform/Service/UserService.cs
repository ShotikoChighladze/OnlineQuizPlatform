using OnlineQuizPlatform.Commands;
using OnlineQuizPlatform.Models;
using OnlineQuizPlatform.Repositorys;

namespace OnlineQuizPlatform.Service
{
    public class UserService
    {
        private UserRepository _userRepository;
        public UserService()
        {
            _userRepository = new UserRepository();
        }
        public void RegisterUser(RegisterCommand command)
        {

            command.Validate();

            var user = new User()
            {

                Name = command.Name,
                Email = command.Email,
                Password = command.Password
            };

           _userRepository.RegisterUser(user);

        }
    }
}
