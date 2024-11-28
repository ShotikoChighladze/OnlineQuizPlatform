using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuizPlatform.Models
{
    public class AnswerQuestionResponse
    {
        public Guid QuizId { get; set; }
        public double Score { get; set; }
        public bool IsFinnished { get; set; }
        public bool TimeOut { get; set; }
        

    }
}
