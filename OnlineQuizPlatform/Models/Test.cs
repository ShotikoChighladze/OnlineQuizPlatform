using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuizPlatform.Models
{
    public class Test
    {
        public Test()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }
        public List<int> QuestionIds { get; set; } 
    }

}
