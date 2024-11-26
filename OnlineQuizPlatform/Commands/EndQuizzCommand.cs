using OnlineQuizPlatform.Models;

namespace OnlineQuizPlatform.Commands;

public class EndQuizzCommand
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int TestId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public List<CostumerAnswer> CostumerAnswers { get; set; }
    public double? Score { get; set; }
}