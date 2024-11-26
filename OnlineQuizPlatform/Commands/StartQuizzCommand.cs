using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineQuizPlatform.Models;

namespace OnlineQuizPlatform.Commands
{
    public class StartQuizzCommand
    {
        public int UserId { get; set; }
        public int TestId { get; set; }
       
    }
}
