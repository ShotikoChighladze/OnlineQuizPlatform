using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuizPlatform.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TestId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; } 
        public List<CostumerAnswer> CostumerAnswers { get; set; }
        public double? Score { get; set; } 
    }

}
