using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuizPlatform.Models
{
    public class CorrectAnswers
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public int CorrectAnswerID { get; set; }
    }
}
