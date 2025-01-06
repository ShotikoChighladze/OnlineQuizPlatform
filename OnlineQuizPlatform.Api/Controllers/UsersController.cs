using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineQuizPlatform.Models;
using OnlineQuizPlatform.Repositorys;

namespace OnlineQuizPlatform.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserRepository _userRepository;
        public UsersController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet ("{id}")]
        public User GerUser(Guid id)
        {
            var user = _userRepository.GetById(id);
            return user;
        }
    }


}
