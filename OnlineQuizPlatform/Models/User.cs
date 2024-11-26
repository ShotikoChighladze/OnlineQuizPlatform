using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineQuizPlatform.Exceptions;
using OnlineQuizPlatform.Service;

namespace OnlineQuizPlatform.Models
{
    public class User
    {
        public User()
        {
            ID = Guid.NewGuid();
        }  
        public Guid ID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

       


    }
}
