using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuizPlatform.Models
{
    public class AskNextQuestionResponse
    {
        public Guid ID { get; set; }
        public string Text { get; set; }
        public List<Answers> PossibleAnswer { get; set; }
        public int QuestionScore { get; set; }
        public bool AllowsMultipleAnswers { get; set; }
    }
}
