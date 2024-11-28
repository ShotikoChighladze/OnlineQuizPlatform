using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuizPlatform.Models
{
    public class CostumerAnswer
    {
        public Guid QuestionId { get; set; }
        public List<Answers> Answers { get; set; }

    }
}
