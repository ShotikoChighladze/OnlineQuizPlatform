using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineQuizPlatform.Models;
using OnlineQuizPlatform.Repositorys;

namespace OnlineQuizPlatform.Commands
{
    public class StartQuizzCommand
    {
        public Guid UserId { get; set; }
        public Guid TestId { get; set; }

        public Guid QuizId {get; set; }
       


        public void Validate()
        {
            if (new TestRepository().GetTestById(TestId) == null)
            {
                throw new ValidationException("Test not found");
            }

            if (new UserRepository().GetById(UserId) == null)
            {
                throw new ValidationException("User not found");
            }
        }

       
    }
}
