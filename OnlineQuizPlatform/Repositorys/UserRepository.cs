using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineQuizPlatform.DB;
using OnlineQuizPlatform.Models;

namespace OnlineQuizPlatform.Repositorys
{
    public class UserRepository
    {

        public User? GetById(Guid id)
        {
            return FakeDB.Data.Users.FirstOrDefault(i => i.ID == id);
        }

        public Guid RegisterUser(User user)
        {

            FakeDB.Data.Users.Add(user);

            FakeDB.SaveState();

            return user.ID;

        }

        public List<User> GetAllUsers()
        {
            return FakeDB.Data.Users;
        }
    }
}

