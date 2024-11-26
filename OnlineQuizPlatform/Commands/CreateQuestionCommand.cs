using OnlineQuizPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineQuizPlatform.Exceptions;

namespace OnlineQuizPlatform.Commands
{
    public class CreateQuestionCommand
    {
        public string Text { get; set; }
        public int QuestionID { get; set; }
        public List<PossibleAnswers> _PossibleAnswer { get; set; }
        public List<CorrectAnswers> CorrectAnswer { get; set; }
        public int QuestionScore { get; set; }
        public bool AllowsMultipleAnswers { get; set; }
        public PossibleAnswers TextAnswer { get; set; }

        public void Validate()
        {
            if (Text.Length < 1 || Text.Length > 2000)
                throw new ValidationException("Questen lenght is requierd 1 to 2000");
            if (_PossibleAnswer.Count < 2 || _PossibleAnswer.Count > 8)
                throw new ValidationException("PossileAnswers must be minimum 2 and maximum 8");
            if (TextAnswer.Text.Length < 1 || TextAnswer.Text.Length > 250)
                throw new ValidationException("Answer Lenght must be between 1 to 250 ");
            if (!AllowsMultipleAnswers)
                throw new ValidationException("MultipleAnswers is not allowed");
            if (QuestionScore < 1 || QuestionScore > 5)
                throw new ValidationException("Text Score must be min 1 or max 5");
            if (!CorrectAnswer.All(correct => _PossibleAnswer.Any(possible => possible.Text == correct.Text)))
                throw new ValidationException("Correct answers must be part of the possible answers.");
            if (CorrectAnswer.Select(answer => answer.CorrectAnswerID).Distinct().Count() != CorrectAnswer.Count)
                throw new ValidationException("Correct answers must not contain duplicates.");
            


        }
    }



}
