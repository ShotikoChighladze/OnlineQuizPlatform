using OnlineQuizPlatform.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuizPlatform.Commands
{
    public class CreateTestCommand
    {
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }
        public List<Guid> QuestionIds { get; set; }
       
        public void Validate()
        {
            if (Title.Length < 1 || Title.Length > 100)
            {
                throw new ValidationException("Title must contain minimum 1 or maximum 100 symbol");
            }

            if (Duration.Minutes < 1 || Duration.Minutes > 60)
            {
                throw new ValidationException("Time must be between 1 to 60 minutes");
            }

            if (QuestionIds.Count < 1 || QuestionIds.Count > 100)
            {
                throw new ValidationException("QuestionIds Must be minimun 1 and maximum 100");
            }

            if (QuestionIds.Any(q => q == null))
            {
                throw new ArgumentException("One or more question IDs are invalid.");
            }

        }
    }
}
