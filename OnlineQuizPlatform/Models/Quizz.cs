using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuizPlatform.Models
{
    public class Quiz
    {
        public Quiz(Guid userId, Guid testId)
        {
            Id = Guid.NewGuid();
            UserId = userId;
            TestId = testId;
            StartTime = DateTime.Now;
            CostumerAnswers = new List<CostumerAnswer>();
            CurrentQuestionIndex = 0;
        }
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid TestId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public TimeSpan Duration { get; set; }
        public bool IsFinished  { get; set; }
        public List<CostumerAnswer> CostumerAnswers { get; set; }
        public double? Score { get; set; }
        public int CurrentQuestionIndex { get; set; }

    }

}
